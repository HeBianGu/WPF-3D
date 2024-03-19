using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kitware.VTK
{
	/// <summary>
	/// UserControl derived implementation of vtkRenderWindow for use
	/// in Windows Forms applications.
	/// The client area of this UserControl is completely filled with
	/// an instance of a vtkRenderWindow.
	/// </summary>
	// Token: 0x02000B8F RID: 2959
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	public class RenderWindowControl : UserControl
	{
		/// <summary>
		/// UserControl derived implementation of vtkRenderWindow for use
		/// in Windows Forms applications.
		/// The client area of this UserControl is completely filled with
		/// an instance of a vtkRenderWindow.
		/// </summary>
		// Token: 0x0601ED87 RID: 126343 RVA: 0x002BC15F File Offset: 0x002BA35F
		public RenderWindowControl()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// TestAddActorsToRenderWindow.
		/// </summary>
		// Token: 0x0601ED88 RID: 126344 RVA: 0x002BC188 File Offset: 0x002BA388
		private void TestAddActorsToRenderWindow(vtkRenderWindow renWin)
		{
			vtkConeSource vtkConeSource = new vtkConeSource();
			vtkMapper vtkMapper = vtkPolyDataMapper.New();
			vtkMapper.SetInputConnection(vtkConeSource.GetOutputPort());
			vtkActor vtkActor = new vtkActor();
			vtkActor.SetMapper(vtkMapper);
			vtkRenderer firstRenderer = renWin.GetRenderers().GetFirstRenderer();
			firstRenderer.AddActor(vtkActor);
			vtkTextActor vtkTextActor = new vtkTextActor();
			vtkTextActor.SetInput(vtkVersion.GetVTKSourceVersion());
			firstRenderer.AddActor(vtkTextActor);
		}

		/// <summary>
		/// This property gives you access to the vtkRenderWindow that
		/// fills the client area.
		/// </summary>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0601ED89 RID: 126345 RVA: 0x002BC1F0 File Offset: 0x002BA3F0
		public vtkRenderWindow RenderWindow
		{
			get
			{
				return this.m_RenderWindow;
			}
		}

		/// <summary>
		/// Text property for test purposes.
		/// </summary>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0601ED8A RID: 126346 RVA: 0x002BC208 File Offset: 0x002BA408
		// (set) Token: 0x0601ED8B RID: 126347 RVA: 0x002BC220 File Offset: 0x002BA420
		public string TestText
		{
			get
			{
				return this.m_TestText;
			}
			set
			{
				this.m_TestText = value;
			}
		}

		/// <summary>
		/// Bool property for test purposes. If true, VTK actors will be added to
		/// the render window in OnHandleCreated.
		/// </summary>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0601ED8C RID: 126348 RVA: 0x002BC22C File Offset: 0x002BA42C
		// (set) Token: 0x0601ED8D RID: 126349 RVA: 0x002BC244 File Offset: 0x002BA444
		public bool AddTestActors
		{
			get
			{
				return this.m_AddTestActors;
			}
			set
			{
				this.m_AddTestActors = value;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		// Token: 0x0601ED8E RID: 126350 RVA: 0x002BC250 File Offset: 0x002BA450
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this.components != null)
					{
						this.components.Dispose();
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>
		/// Called to set the vtkRenderWindow size according to this control's
		/// Size property.
		/// </summary>
		// Token: 0x0601ED8F RID: 126351 RVA: 0x002BC2A4 File Offset: 0x002BA4A4
		internal void SyncRenderWindowSize()
		{
			if (this.m_RenderWindow != null)
			{
				this.m_RenderWindow.SetSize(base.Size.Width, base.Size.Height);
			}
		}

		/// <summary>
		/// Retrieve the X11 Display* to pass to VTK's vtkRenderWindow::SetDisplayId
		/// </summary>
		// Token: 0x0601ED90 RID: 126352 RVA: 0x002BC2EC File Offset: 0x002BA4EC
		private IntPtr GetXDisplay()
		{
			Type type = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
			if (type != null)
			{
				IntPtr xdisplay = (IntPtr)type.GetField("DisplayHandle", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
				this.XDisplay = xdisplay;
			}
			return this.XDisplay;
		}

		// Token: 0x0601ED91 RID: 126353 RVA: 0x002BC340 File Offset: 0x002BA540
		private void AttachInteractor()
		{
			if (!this.AttachedInteractor)
			{
				this.AttachedInteractor = true;
				this.m_RenderWindow.SetInteractor(this.m_RenderWindowInteractor);
			}
		}

		/// <summary>
		/// OnHandleCreated.
		/// </summary>
		// Token: 0x0601ED92 RID: 126354 RVA: 0x002BC374 File Offset: 0x002BA574
		protected override void OnHandleCreated(EventArgs e)
		{
			if (!base.DesignMode)
			{
				vtkLogoWidget vtkLogoWidget = new vtkLogoWidget();
				this.m_Renderer = vtkRenderer.New();
				this.m_RenderWindow = vtkRenderWindow.New();
				IntPtr xdisplay = this.GetXDisplay();
				bool flag = false;
				if (IntPtr.Zero != xdisplay)
				{
					flag = true;
				}
				if (flag)
				{
					this.m_RenderWindowInteractor = vtkGenericRenderWindowInteractor.New();
					this.m_RenderWindow.SetDisplayId(xdisplay);
				}
				else
				{
					this.m_RenderWindowInteractor = vtkRenderWindowInteractor.New();
				}
				vtkInteractorStyleSwitch vtkInteractorStyleSwitch = this.m_RenderWindowInteractor.GetInteractorStyle() as vtkInteractorStyleSwitch;
				if (null != vtkInteractorStyleSwitch)
				{
					vtkInteractorStyleSwitch.SetCurrentStyleToTrackballCamera();
				}
				this.m_RenderWindow.SetParentId(base.Handle);
				this.m_RenderWindow.AddRenderer(this.m_Renderer);
				if (!flag)
				{
					this.AttachInteractor();
				}
				vtkLogoWidget.Dispose();
			}
			base.OnHandleCreated(e);
		}

		/// <summary>
		/// OnHandleDestroyed.
		/// </summary>
		// Token: 0x0601ED93 RID: 126355 RVA: 0x002BC46C File Offset: 0x002BA66C
		protected override void OnHandleDestroyed(EventArgs e)
		{
			if (this.m_Renderer != null)
			{
				this.m_Renderer.SetRenderWindow(null);
			}
			if (this.m_RenderWindowInteractor != null)
			{
				this.m_RenderWindowInteractor.Dispose();
				this.m_RenderWindowInteractor = null;
			}
			if (this.m_RenderWindow != null)
			{
				this.m_RenderWindow.Dispose();
				this.m_RenderWindow = null;
			}
			if (this.m_Renderer != null)
			{
				this.m_Renderer.Dispose();
				this.m_Renderer = null;
			}
			base.OnHandleDestroyed(e);
		}

		/// <summary>
		/// OnMouseDown.
		/// </summary>
		// Token: 0x0601ED94 RID: 126356 RVA: 0x002BC504 File Offset: 0x002BA704
		protected override void OnMouseDown(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				MouseButtons button = e.Button;
				if (button != MouseButtons.Left)
				{
					if (button != MouseButtons.Right)
					{
						if (button == MouseButtons.Middle)
						{
							vtkGenericRenderWindowInteractor.MiddleButtonPressEvent();
						}
					}
					else
					{
						vtkGenericRenderWindowInteractor.RightButtonPressEvent();
					}
				}
				else
				{
					vtkGenericRenderWindowInteractor.LeftButtonPressEvent();
				}
			}
		}

		/// <summary>
		/// OnMouseMove.
		/// </summary>
		// Token: 0x0601ED95 RID: 126357 RVA: 0x002BC584 File Offset: 0x002BA784
		protected override void OnMouseMove(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				vtkGenericRenderWindowInteractor.MouseMoveEvent();
			}
		}

		/// <summary>
		/// OnMouseUp.
		/// </summary>
		// Token: 0x0601ED96 RID: 126358 RVA: 0x002BC5CC File Offset: 0x002BA7CC
		protected override void OnMouseUp(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				MouseButtons button = e.Button;
				if (button != MouseButtons.Left)
				{
					if (button != MouseButtons.Right)
					{
						if (button == MouseButtons.Middle)
						{
							vtkGenericRenderWindowInteractor.MiddleButtonReleaseEvent();
						}
					}
					else
					{
						vtkGenericRenderWindowInteractor.RightButtonReleaseEvent();
					}
				}
				else
				{
					vtkGenericRenderWindowInteractor.LeftButtonReleaseEvent();
				}
			}
		}

		/// <summary>
		/// OnMouseWheel.
		/// </summary>
		// Token: 0x0601ED97 RID: 126359 RVA: 0x002BC64C File Offset: 0x002BA84C
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
				if (e.Delta > 0)
				{
					vtkGenericRenderWindowInteractor.MouseWheelForwardEvent();
				}
				else
				{
					vtkGenericRenderWindowInteractor.MouseWheelBackwardEvent();
				}
			}
		}

		/// <summary>
		/// OnKeyDown.
		/// </summary>
		// Token: 0x0601ED98 RID: 126360 RVA: 0x002BC6B4 File Offset: 0x002BA8B4
		protected override void OnKeyDown(KeyEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(e.Control ? (byte)1 : (byte)0, e.Shift ? (byte)1 : (byte)0, (sbyte)e.KeyCode, 1, null);
				vtkGenericRenderWindowInteractor.KeyPressEvent();
			}
		}

		/// <summary>
		/// OnKeyPress.
		/// </summary>
		// Token: 0x0601ED99 RID: 126361 RVA: 0x002BC70C File Offset: 0x002BA90C
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(0, 0, (sbyte)e.KeyChar, 1, e.KeyChar.ToString());
				vtkGenericRenderWindowInteractor.CharEvent();
			}
		}

		/// <summary>
		/// OnKeyUp.
		/// </summary>
		// Token: 0x0601ED9A RID: 126362 RVA: 0x002BC758 File Offset: 0x002BA958
		protected override void OnKeyUp(KeyEventArgs e)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.SetKeyEventInformation(e.Control ? (byte)1 : (byte)0, e.Shift ? (byte)1 : (byte)0, (sbyte)e.KeyCode, 1, null);
				vtkGenericRenderWindowInteractor.KeyReleaseEvent();
			}
		}

		/// <summary>
		/// OnSizeChanged fires after the Size property has changed value.
		/// </summary>
		// Token: 0x0601ED9B RID: 126363 RVA: 0x002BC7B0 File Offset: 0x002BA9B0
		protected override void OnSizeChanged(EventArgs e)
		{
			this.SyncRenderWindowSize();
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = this.m_RenderWindowInteractor as vtkGenericRenderWindowInteractor;
			if (null != vtkGenericRenderWindowInteractor)
			{
				vtkGenericRenderWindowInteractor.ConfigureEvent();
			}
			base.OnSizeChanged(e);
			base.Invalidate();
		}

		// Token: 0x0601ED9C RID: 126364
		[DllImport("user32.dll")]
		internal static extern IntPtr SetFocus(IntPtr hWnd);

		/// <summary>
		/// OnGotFocus fires after Windows keyboard focus enters the control.
		/// </summary>
		// Token: 0x0601ED9D RID: 126365 RVA: 0x002BC7F4 File Offset: 0x002BA9F4
		protected override void OnGotFocus(EventArgs e)
		{
			if (this.m_RenderWindow != null)
			{
				IntPtr genericWindowId = this.m_RenderWindow.GetGenericWindowId();
				if (IntPtr.Zero != genericWindowId)
				{
					try
					{
						RenderWindowControl.SetFocus(genericWindowId);
					}
					catch
					{
					}
				}
			}
			base.OnGotFocus(e);
		}

		/// <summary>
		/// Override to do "last minute cram" of child control...
		/// </summary>
		// Token: 0x0601ED9E RID: 126366 RVA: 0x002BC85C File Offset: 0x002BAA5C
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.m_RenderWindow != null)
			{
				if (base.Visible)
				{
					this.SyncRenderWindowSize();
					if (this.m_RenderWindow.GetInteractor() != this.m_RenderWindowInteractor)
					{
						this.AttachInteractor();
						this.m_RenderWindow.Render();
					}
					if (this.AddTestActors && !this.m_AddedTestActors)
					{
						this.m_AddedTestActors = true;
						this.TestAddActorsToRenderWindow(this.m_RenderWindow);
					}
					this.m_RenderWindow.Render();
				}
			}
			base.OnPaint(e);
		}

		/// <summary>
		/// OnVisibleChanged fires after the Visible property has changed value.
		/// </summary>
		// Token: 0x0601ED9F RID: 126367 RVA: 0x002BC8FB File Offset: 0x002BAAFB
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
		}

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		// Token: 0x0601EDA0 RID: 126368 RVA: 0x002BC908 File Offset: 0x002BAB08
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "RenderWindowControl";
			base.Size = new Size(400, 300);
			base.ResumeLayout(false);
		}

		// Token: 0x0400210E RID: 8462
		private vtkRenderer m_Renderer;

		// Token: 0x0400210F RID: 8463
		private vtkRenderWindow m_RenderWindow;

		// Token: 0x04002110 RID: 8464
		private vtkRenderWindowInteractor m_RenderWindowInteractor;

		// Token: 0x04002111 RID: 8465
		private string m_TestText;

		// Token: 0x04002112 RID: 8466
		private bool m_AddTestActors = false;

		// Token: 0x04002113 RID: 8467
		private bool m_AddedTestActors = false;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		// Token: 0x04002114 RID: 8468
		private IContainer components = null;

		// Token: 0x04002115 RID: 8469
		private IntPtr XDisplay;

		// Token: 0x04002116 RID: 8470
		private bool AttachedInteractor;
	}
}
