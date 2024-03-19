using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPropPicker
	/// </summary>
	/// <remarks>
	///    pick an actor/prop using graphics hardware
	///
	/// vtkPropPicker is used to pick an actor/prop given a selection
	/// point (in display coordinates) and a renderer. This class uses
	/// graphics hardware/rendering system to pick rapidly (as compared
	/// to using ray casting as does vtkCellPicker and vtkPointPicker).
	/// This class determines the actor/prop and pick position in world
	/// coordinates; point and cell ids are not determined.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
	/// </seealso>
	// Token: 0x020000BE RID: 190
	public class vtkPropPicker : vtkAbstractPropPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060029A8 RID: 10664 RVA: 0x0003D847 File Offset: 0x0003BA47
		static vtkPropPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060029A9 RID: 10665 RVA: 0x0003D86F File Offset: 0x0003BA6F
		public vtkPropPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060029AA RID: 10666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029AB RID: 10667 RVA: 0x0003D880 File Offset: 0x0003BA80
		public new static vtkPropPicker New()
		{
			vtkPropPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029AC RID: 10668 RVA: 0x0003D8D4 File Offset: 0x0003BAD4
		public vtkPropPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPropPicker.vtkPropPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060029AD RID: 10669 RVA: 0x0003D918 File Offset: 0x0003BB18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060029AE RID: 10670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029AF RID: 10671 RVA: 0x0003D924 File Offset: 0x0003BB24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPropPicker.vtkPropPicker_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060029B0 RID: 10672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropPicker_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029B1 RID: 10673 RVA: 0x0003D944 File Offset: 0x0003BB44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPropPicker.vtkPropPicker_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060029B2 RID: 10674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029B3 RID: 10675 RVA: 0x0003D960 File Offset: 0x0003BB60
		public override int IsA(string type)
		{
			return vtkPropPicker.vtkPropPicker_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060029B4 RID: 10676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029B5 RID: 10677 RVA: 0x0003D980 File Offset: 0x0003BB80
		public new static int IsTypeOf(string type)
		{
			return vtkPropPicker.vtkPropPicker_IsTypeOf_04(type);
		}

		// Token: 0x060029B6 RID: 10678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropPicker_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029B7 RID: 10679 RVA: 0x0003D99C File Offset: 0x0003BB9C
		public new vtkPropPicker NewInstance()
		{
			vtkPropPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060029B8 RID: 10680
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_Pick_07(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// override superclasses' Pick() method.
		/// </summary>
		// Token: 0x060029B9 RID: 10681 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_Pick_07(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x060029BA RID: 10682
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_Pick_08(HandleRef pThis, IntPtr selectionPt, HandleRef renderer);

		/// <summary>
		/// override superclasses' Pick() method.
		/// </summary>
		// Token: 0x060029BB RID: 10683 RVA: 0x0003DA34 File Offset: 0x0003BC34
		public new int Pick(IntPtr selectionPt, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_Pick_08(base.GetCppThis(), selectionPt, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x060029BC RID: 10684
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_Pick3DPoint_09(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x060029BD RID: 10685 RVA: 0x0003DA6C File Offset: 0x0003BC6C
		public override int Pick3DPoint(IntPtr selectionPt, vtkRenderer ren)
		{
			return vtkPropPicker.vtkPropPicker_Pick3DPoint_09(base.GetCppThis(), selectionPt, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060029BE RID: 10686
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_Pick3DRay_10(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

		/// <summary>
		/// Perform pick operation with selection point provided. The
		/// selectionPt is in world coordinates.
		/// Return non-zero if something was successfully picked.
		/// </summary>
		// Token: 0x060029BF RID: 10687 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
		{
			return vtkPropPicker.vtkPropPicker_Pick3DRay_10(base.GetCppThis(), selectionPt, orient, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060029C0 RID: 10688
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_PickProp_11(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer);

		/// <summary>
		/// Perform the pick and set the PickedProp ivar. If something is picked, a
		/// 1 is returned, otherwise 0 is returned.  Use the GetViewProp() method
		/// to get the instance of vtkProp that was picked.  Props are picked from
		/// the renderers list of pickable Props.
		/// </summary>
		// Token: 0x060029C1 RID: 10689 RVA: 0x0003DADC File Offset: 0x0003BCDC
		public int PickProp(double selectionX, double selectionY, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_PickProp_11(base.GetCppThis(), selectionX, selectionY, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x060029C2 RID: 10690
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_PickProp_12(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer, HandleRef pickfrom);

		/// <summary>
		/// Perform a pick from the user-provided list of vtkProps and not from the
		/// list of vtkProps that the render maintains.
		/// </summary>
		// Token: 0x060029C3 RID: 10691 RVA: 0x0003DB14 File Offset: 0x0003BD14
		public int PickProp(double selectionX, double selectionY, vtkRenderer renderer, vtkPropCollection pickfrom)
		{
			return vtkPropPicker.vtkPropPicker_PickProp_12(base.GetCppThis(), selectionX, selectionY, (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (pickfrom == null) ? default(HandleRef) : pickfrom.GetCppThis());
		}

		// Token: 0x060029C4 RID: 10692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_PickProp3DPoint_13(HandleRef pThis, IntPtr pos, HandleRef renderer);

		/// <summary>
		/// Perform the pick and set the PickedProp ivar. If something is picked, a
		/// 1 is returned, otherwise 0 is returned.  Use the GetViewProp() method
		/// to get the instance of vtkProp that was picked.  Props are picked from
		/// the renderers list of pickable Props.
		/// </summary>
		// Token: 0x060029C5 RID: 10693 RVA: 0x0003DB64 File Offset: 0x0003BD64
		public int PickProp3DPoint(IntPtr pos, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_PickProp3DPoint_13(base.GetCppThis(), pos, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x060029C6 RID: 10694
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_PickProp3DPoint_14(HandleRef pThis, IntPtr pos, HandleRef renderer, HandleRef pickfrom);

		/// <summary>
		/// Perform a pick from the user-provided list of vtkProps and not from the
		/// list of vtkProps that the render maintains.
		/// </summary>
		// Token: 0x060029C7 RID: 10695 RVA: 0x0003DB9C File Offset: 0x0003BD9C
		public int PickProp3DPoint(IntPtr pos, vtkRenderer renderer, vtkPropCollection pickfrom)
		{
			return vtkPropPicker.vtkPropPicker_PickProp3DPoint_14(base.GetCppThis(), pos, (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (pickfrom == null) ? default(HandleRef) : pickfrom.GetCppThis());
		}

		// Token: 0x060029C8 RID: 10696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropPicker_PickProp3DRay_15(HandleRef pThis, IntPtr selectionPt, IntPtr eventWorldOrientation, HandleRef renderer, HandleRef pickfrom);

		/// <summary>
		/// Perform a pick from the user-provided list of vtkProps.
		/// </summary>
		// Token: 0x060029C9 RID: 10697 RVA: 0x0003DBE8 File Offset: 0x0003BDE8
		public virtual int PickProp3DRay(IntPtr selectionPt, IntPtr eventWorldOrientation, vtkRenderer renderer, vtkPropCollection pickfrom)
		{
			return vtkPropPicker.vtkPropPicker_PickProp3DRay_15(base.GetCppThis(), selectionPt, eventWorldOrientation, (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (pickfrom == null) ? default(HandleRef) : pickfrom.GetCppThis());
		}

		// Token: 0x060029CA RID: 10698
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropPicker_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029CB RID: 10699 RVA: 0x0003DC38 File Offset: 0x0003BE38
		public new static vtkPropPicker SafeDownCast(vtkObjectBase o)
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropPicker = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropPicker.Register(null);
				}
			}
			return vtkPropPicker;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000568 RID: 1384
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000569 RID: 1385
		public new static readonly string MRClassNameKey = "class vtkPropPicker";
	}
}
