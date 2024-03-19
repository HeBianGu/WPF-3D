using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScenePicker
	/// </summary>
	/// <remarks>
	///    Picks an entire viewport at one shot.
	///
	/// The Scene picker, unlike conventional pickers picks an entire viewport at
	/// one shot and caches the result, which can be retrieved later.
	///    The utility of the class arises during &lt;b&gt;Actor Selection&lt;/b&gt;. Let's
	/// say you have a couple of polygonal objects in your scene and you wish to
	/// have a status bar that indicates the object your mouse is over. Picking
	/// repeatedly every time your mouse moves would be very slow. The
	/// scene picker automatically picks your viewport every time the camera is
	/// changed and caches the information. Additionally, it observes the
	/// vtkRenderWindowInteractor to avoid picking during interaction, so that
	/// you still maintain your interactivity. In effect, the picker does an
	/// additional pick-render of your scene every time you stop interacting with
	/// your scene. As an example, see Rendering/TestScenePicker.
	///
	/// @warning
	/// - Unlike a vtkHoverWidget, this class is not timer based. The hover widget
	///   picks a scene when the mouse is over an actor for a specified duration.
	/// - This class uses a vtkHardwareSelector under the hood. Hence, it will
	///   work only for actors that have opaque geometry and are rendered by a
	///   vtkPolyDataMapper.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHoverWidget vtkHardwareSelector
	/// </seealso>
	// Token: 0x02000816 RID: 2070
	public class vtkScenePicker : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060154B0 RID: 87216 RVA: 0x001E296B File Offset: 0x001E0B6B
		static vtkScenePicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScenePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScenePicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060154B1 RID: 87217 RVA: 0x001E2993 File Offset: 0x001E0B93
		public vtkScenePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060154B2 RID: 87218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScenePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154B3 RID: 87219 RVA: 0x001E29A4 File Offset: 0x001E0BA4
		public new static vtkScenePicker New()
		{
			vtkScenePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154B4 RID: 87220 RVA: 0x001E29F8 File Offset: 0x001E0BF8
		public vtkScenePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScenePicker.vtkScenePicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060154B5 RID: 87221 RVA: 0x001E2A3C File Offset: 0x001E0C3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060154B6 RID: 87222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScenePicker_EnableVertexPickingOff_01(HandleRef pThis);

		/// <summary>
		/// Vertex picking (using the method GetVertexId()), required
		/// additional resources and can slow down still render time by
		/// 5-10%. Enabled by default.
		/// </summary>
		// Token: 0x060154B7 RID: 87223 RVA: 0x001E2A47 File Offset: 0x001E0C47
		public virtual void EnableVertexPickingOff()
		{
			vtkScenePicker.vtkScenePicker_EnableVertexPickingOff_01(base.GetCppThis());
		}

		// Token: 0x060154B8 RID: 87224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScenePicker_EnableVertexPickingOn_02(HandleRef pThis);

		/// <summary>
		/// Vertex picking (using the method GetVertexId()), required
		/// additional resources and can slow down still render time by
		/// 5-10%. Enabled by default.
		/// </summary>
		// Token: 0x060154B9 RID: 87225 RVA: 0x001E2A56 File Offset: 0x001E0C56
		public virtual void EnableVertexPickingOn()
		{
			vtkScenePicker.vtkScenePicker_EnableVertexPickingOn_02(base.GetCppThis());
		}

		// Token: 0x060154BA RID: 87226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScenePicker_GetCellId_03(HandleRef pThis, IntPtr displayPos);

		/// <summary>
		/// Get cell id at the pick position.
		/// Returns -1 if no cell was picked.
		/// Makes sense only after Pick has been called.
		/// </summary>
		// Token: 0x060154BB RID: 87227 RVA: 0x001E2A68 File Offset: 0x001E0C68
		public long GetCellId(IntPtr displayPos)
		{
			return vtkScenePicker.vtkScenePicker_GetCellId_03(base.GetCppThis(), displayPos);
		}

		// Token: 0x060154BC RID: 87228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScenePicker_GetEnableVertexPicking_04(HandleRef pThis);

		/// <summary>
		/// Vertex picking (using the method GetVertexId()), required
		/// additional resources and can slow down still render time by
		/// 5-10%. Enabled by default.
		/// </summary>
		// Token: 0x060154BD RID: 87229 RVA: 0x001E2A88 File Offset: 0x001E0C88
		public virtual int GetEnableVertexPicking()
		{
			return vtkScenePicker.vtkScenePicker_GetEnableVertexPicking_04(base.GetCppThis());
		}

		// Token: 0x060154BE RID: 87230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScenePicker_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154BF RID: 87231 RVA: 0x001E2AA8 File Offset: 0x001E0CA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScenePicker.vtkScenePicker_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060154C0 RID: 87232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScenePicker_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154C1 RID: 87233 RVA: 0x001E2AC8 File Offset: 0x001E0CC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScenePicker.vtkScenePicker_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060154C2 RID: 87234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScenePicker_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the renderer. Scene picks are restricted to the viewport.
		/// </summary>
		// Token: 0x060154C3 RID: 87235 RVA: 0x001E2AE4 File Offset: 0x001E0CE4
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_GetRenderer_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060154C4 RID: 87236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScenePicker_GetVertexId_08(HandleRef pThis, IntPtr displayPos);

		/// <summary>
		/// Get cell id at the pick position.
		/// Returns -1 if no cell was picked.
		/// Makes sense only after Pick has been called.
		/// </summary>
		// Token: 0x060154C5 RID: 87237 RVA: 0x001E2B54 File Offset: 0x001E0D54
		public long GetVertexId(IntPtr displayPos)
		{
			return vtkScenePicker.vtkScenePicker_GetVertexId_08(base.GetCppThis(), displayPos);
		}

		// Token: 0x060154C6 RID: 87238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScenePicker_GetViewProp_09(HandleRef pThis, IntPtr displayPos, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get actor at the pick position.
		/// Returns NULL if none.
		/// Makes sense only after Pick has been called.
		/// </summary>
		// Token: 0x060154C7 RID: 87239 RVA: 0x001E2B74 File Offset: 0x001E0D74
		public vtkProp GetViewProp(IntPtr displayPos)
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_GetViewProp_09(base.GetCppThis(), displayPos, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x060154C8 RID: 87240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScenePicker_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154C9 RID: 87241 RVA: 0x001E2BE4 File Offset: 0x001E0DE4
		public override int IsA(string type)
		{
			return vtkScenePicker.vtkScenePicker_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060154CA RID: 87242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScenePicker_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154CB RID: 87243 RVA: 0x001E2C04 File Offset: 0x001E0E04
		public new static int IsTypeOf(string type)
		{
			return vtkScenePicker.vtkScenePicker_IsTypeOf_11(type);
		}

		// Token: 0x060154CC RID: 87244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScenePicker_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154CD RID: 87245 RVA: 0x001E2C20 File Offset: 0x001E0E20
		public new vtkScenePicker NewInstance()
		{
			vtkScenePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060154CE RID: 87246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScenePicker_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154CF RID: 87247 RVA: 0x001E2C7C File Offset: 0x001E0E7C
		public new static vtkScenePicker SafeDownCast(vtkObjectBase o)
		{
			vtkScenePicker vtkScenePicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScenePicker.vtkScenePicker_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScenePicker = (vtkScenePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScenePicker.Register(null);
				}
			}
			return vtkScenePicker;
		}

		// Token: 0x060154D0 RID: 87248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScenePicker_SetEnableVertexPicking_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Vertex picking (using the method GetVertexId()), required
		/// additional resources and can slow down still render time by
		/// 5-10%. Enabled by default.
		/// </summary>
		// Token: 0x060154D1 RID: 87249 RVA: 0x001E2CFB File Offset: 0x001E0EFB
		public virtual void SetEnableVertexPicking(int _arg)
		{
			vtkScenePicker.vtkScenePicker_SetEnableVertexPicking_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060154D2 RID: 87250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScenePicker_SetRenderer_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the renderer. Scene picks are restricted to the viewport.
		/// </summary>
		// Token: 0x060154D3 RID: 87251 RVA: 0x001E2D0C File Offset: 0x001E0F0C
		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkScenePicker.vtkScenePicker_SetRenderer_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001874 RID: 6260
		public new const string MRFullTypeName = "Kitware.VTK.vtkScenePicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001875 RID: 6261
		public new static readonly string MRClassNameKey = "class vtkScenePicker";
	}
}
