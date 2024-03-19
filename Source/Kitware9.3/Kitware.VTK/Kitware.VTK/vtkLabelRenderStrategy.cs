using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelRenderStrategy
	/// </summary>
	/// <remarks>
	///    Superclass for label rendering implementations.
	///
	///
	/// These methods should only be called within a mapper.
	/// </remarks>
	// Token: 0x020000E5 RID: 229
	public abstract class vtkLabelRenderStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002F96 RID: 12182 RVA: 0x0004599F File Offset: 0x00043B9F
		static vtkLabelRenderStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelRenderStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelRenderStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002F97 RID: 12183 RVA: 0x000459C7 File Offset: 0x00043BC7
		public vtkLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002F98 RID: 12184 RVA: 0x000459D5 File Offset: 0x00043BD5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002F99 RID: 12185
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_ComputeLabelBounds_01(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string label, IntPtr bds);

		/// <summary>
		/// Compute the bounds of a label. Must be performed after the renderer is set.
		/// </summary>
		// Token: 0x06002F9A RID: 12186 RVA: 0x000459E0 File Offset: 0x00043BE0
		public virtual void ComputeLabelBounds(vtkTextProperty tprop, string label, IntPtr bds)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_ComputeLabelBounds_01(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), label, bds);
		}

		// Token: 0x06002F9B RID: 12187
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_EndFrame_02(HandleRef pThis);

		/// <summary>
		/// End a rendering frame.
		/// </summary>
		// Token: 0x06002F9C RID: 12188 RVA: 0x00045A11 File Offset: 0x00043C11
		public virtual void EndFrame()
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_EndFrame_02(base.GetCppThis());
		}

		// Token: 0x06002F9D RID: 12189
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelRenderStrategy_GetDefaultTextProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the default text property for the strategy.
		/// </summary>
		// Token: 0x06002F9E RID: 12190 RVA: 0x00045A20 File Offset: 0x00043C20
		public virtual vtkTextProperty GetDefaultTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetDefaultTextProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06002F9F RID: 12191
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelRenderStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FA0 RID: 12192 RVA: 0x00045A90 File Offset: 0x00043C90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06002FA1 RID: 12193
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FA2 RID: 12194 RVA: 0x00045AB0 File Offset: 0x00043CB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06002FA3 RID: 12195
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelRenderStrategy_GetRenderer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the renderer associated with this strategy.
		/// </summary>
		// Token: 0x06002FA4 RID: 12196 RVA: 0x00045ACC File Offset: 0x00043CCC
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetRenderer_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06002FA5 RID: 12197
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelRenderStrategy_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FA6 RID: 12198 RVA: 0x00045B3C File Offset: 0x00043D3C
		public override int IsA(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06002FA7 RID: 12199
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelRenderStrategy_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FA8 RID: 12200 RVA: 0x00045B5C File Offset: 0x00043D5C
		public new static int IsTypeOf(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_IsTypeOf_08(type);
		}

		// Token: 0x06002FA9 RID: 12201
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelRenderStrategy_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FAA RID: 12202 RVA: 0x00045B78 File Offset: 0x00043D78
		public new vtkLabelRenderStrategy NewInstance()
		{
			vtkLabelRenderStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002FAB RID: 12203
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this strategy.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002FAC RID: 12204 RVA: 0x00045BD4 File Offset: 0x00043DD4
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002FAD RID: 12205
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_RenderLabel_11(HandleRef pThis, IntPtr x, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Render a label at a location in display coordinates.
		/// Must be performed between StartFrame() and EndFrame() calls.
		/// The optional final parameter maxWidth specifies a maximum width for the label.
		/// Longer labels can be shorted with an ellipsis (...). Only renderer strategies
		/// that return true from SupportsBoundedSize must implement this version of th
		/// method.
		/// </summary>
		// Token: 0x06002FAE RID: 12206 RVA: 0x00045C04 File Offset: 0x00043E04
		public virtual void RenderLabel(IntPtr x, vtkTextProperty tprop, string label)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_RenderLabel_11(base.GetCppThis(), x, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), label);
		}

		// Token: 0x06002FAF RID: 12207
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_RenderLabel_12(HandleRef pThis, IntPtr x, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string label, int arg3);

		/// <summary>
		/// Render a label at a location in display coordinates.
		/// Must be performed between StartFrame() and EndFrame() calls.
		/// The optional final parameter maxWidth specifies a maximum width for the label.
		/// Longer labels can be shorted with an ellipsis (...). Only renderer strategies
		/// that return true from SupportsBoundedSize must implement this version of th
		/// method.
		/// </summary>
		// Token: 0x06002FB0 RID: 12208 RVA: 0x00045C38 File Offset: 0x00043E38
		public virtual void RenderLabel(IntPtr x, vtkTextProperty tprop, string label, int arg3)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_RenderLabel_12(base.GetCppThis(), x, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), label, arg3);
		}

		// Token: 0x06002FB1 RID: 12209
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelRenderStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FB2 RID: 12210 RVA: 0x00045C6C File Offset: 0x00043E6C
		public new static vtkLabelRenderStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkLabelRenderStrategy vtkLabelRenderStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelRenderStrategy = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelRenderStrategy.Register(null);
				}
			}
			return vtkLabelRenderStrategy;
		}

		// Token: 0x06002FB3 RID: 12211
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_SetDefaultTextProperty_14(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// Set the default text property for the strategy.
		/// </summary>
		// Token: 0x06002FB4 RID: 12212 RVA: 0x00045CEC File Offset: 0x00043EEC
		public virtual void SetDefaultTextProperty(vtkTextProperty tprop)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_SetDefaultTextProperty_14(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06002FB5 RID: 12213
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_SetRenderer_15(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Set the renderer associated with this strategy.
		/// </summary>
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00045D1C File Offset: 0x00043F1C
		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_SetRenderer_15(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002FB7 RID: 12215
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelRenderStrategy_StartFrame_16(HandleRef pThis);

		/// <summary>
		/// Start a rendering frame. Renderer must be set.
		/// </summary>
		// Token: 0x06002FB8 RID: 12216 RVA: 0x00045D4B File Offset: 0x00043F4B
		public virtual void StartFrame()
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_StartFrame_16(base.GetCppThis());
		}

		// Token: 0x06002FB9 RID: 12217
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelRenderStrategy_SupportsBoundedSize_17(HandleRef pThis);

		/// <summary>
		/// Whether the text rendering strategy supports bounded size.
		/// The superclass returns true. Subclasses should override this to
		/// return the appropriate value. Subclasses that return true
		/// from this method should implement the version of RenderLabel()
		/// that takes a maximum size (see RenderLabel()).
		/// </summary>
		// Token: 0x06002FBA RID: 12218 RVA: 0x00045D5C File Offset: 0x00043F5C
		public virtual bool SupportsBoundedSize()
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_SupportsBoundedSize_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06002FBB RID: 12219
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelRenderStrategy_SupportsRotation_18(HandleRef pThis);

		/// <summary>
		/// Whether the text rendering strategy supports rotation.
		/// The superclass returns true. Subclasses should override this to
		/// return the appropriate value.
		/// </summary>
		// Token: 0x06002FBC RID: 12220 RVA: 0x00045D84 File Offset: 0x00043F84
		public virtual bool SupportsRotation()
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_SupportsRotation_18(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005CF RID: 1487
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelRenderStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D0 RID: 1488
		public new static readonly string MRClassNameKey = "class vtkLabelRenderStrategy";
	}
}
