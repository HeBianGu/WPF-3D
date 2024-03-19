using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRHardwarePicker
	/// </summary>
	/// <remarks>
	///    pick an actor/prop given a controller position and orientation
	///
	/// vtkVRHardwarePicker is used to pick an actor/prop along a ray.
	/// This version uses a hardware selector to do the picking.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp3DPicker vtkVRInteractorStylePointer
	/// </seealso>
	// Token: 0x020000BF RID: 191
	public class vtkVRHardwarePicker : vtkPropPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060029CC RID: 10700 RVA: 0x0003DCB7 File Offset: 0x0003BEB7
		static vtkVRHardwarePicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRHardwarePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRHardwarePicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060029CD RID: 10701 RVA: 0x0003DCDF File Offset: 0x0003BEDF
		public vtkVRHardwarePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060029CE RID: 10702
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHardwarePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029CF RID: 10703 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		public new static vtkVRHardwarePicker New()
		{
			vtkVRHardwarePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHardwarePicker.vtkVRHardwarePicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029D0 RID: 10704 RVA: 0x0003DD44 File Offset: 0x0003BF44
		public vtkVRHardwarePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRHardwarePicker.vtkVRHardwarePicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060029D1 RID: 10705 RVA: 0x0003DD88 File Offset: 0x0003BF88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060029D2 RID: 10706
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRHardwarePicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029D3 RID: 10707 RVA: 0x0003DD94 File Offset: 0x0003BF94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRHardwarePicker.vtkVRHardwarePicker_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060029D4 RID: 10708
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRHardwarePicker_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029D5 RID: 10709 RVA: 0x0003DDB4 File Offset: 0x0003BFB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRHardwarePicker.vtkVRHardwarePicker_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060029D6 RID: 10710
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHardwarePicker_GetSelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Perform a pick from the user-provided list of vtkProps.
		/// </summary>
		// Token: 0x060029D7 RID: 10711 RVA: 0x0003DDD0 File Offset: 0x0003BFD0
		public vtkSelection GetSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHardwarePicker.vtkVRHardwarePicker_GetSelection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x060029D8 RID: 10712
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRHardwarePicker_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029D9 RID: 10713 RVA: 0x0003DE40 File Offset: 0x0003C040
		public override int IsA(string type)
		{
			return vtkVRHardwarePicker.vtkVRHardwarePicker_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060029DA RID: 10714
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRHardwarePicker_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029DB RID: 10715 RVA: 0x0003DE60 File Offset: 0x0003C060
		public new static int IsTypeOf(string type)
		{
			return vtkVRHardwarePicker.vtkVRHardwarePicker_IsTypeOf_05(type);
		}

		// Token: 0x060029DC RID: 10716
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHardwarePicker_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029DD RID: 10717 RVA: 0x0003DE7C File Offset: 0x0003C07C
		public new vtkVRHardwarePicker NewInstance()
		{
			vtkVRHardwarePicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHardwarePicker.vtkVRHardwarePicker_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060029DE RID: 10718
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRHardwarePicker_PickProp_08(HandleRef pThis, IntPtr selectionPt, IntPtr eventWorldOrientation, HandleRef renderer, HandleRef pickfrom, byte actorPassOnly);

		/// <summary>
		/// Perform a pick from the user-provided list of vtkProps.
		/// </summary>
		// Token: 0x060029DF RID: 10719 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		public virtual int PickProp(IntPtr selectionPt, IntPtr eventWorldOrientation, vtkRenderer renderer, vtkPropCollection pickfrom, bool actorPassOnly)
		{
			return vtkVRHardwarePicker.vtkVRHardwarePicker_PickProp_08(base.GetCppThis(), selectionPt, eventWorldOrientation, (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (pickfrom == null) ? default(HandleRef) : pickfrom.GetCppThis(), actorPassOnly ? (byte)1 : (byte)0);
		}

		// Token: 0x060029E0 RID: 10720
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRHardwarePicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029E1 RID: 10721 RVA: 0x0003DF30 File Offset: 0x0003C130
		public new static vtkVRHardwarePicker SafeDownCast(vtkObjectBase o)
		{
			vtkVRHardwarePicker vtkVRHardwarePicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRHardwarePicker.vtkVRHardwarePicker_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRHardwarePicker = (vtkVRHardwarePicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRHardwarePicker.Register(null);
				}
			}
			return vtkVRHardwarePicker;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400056A RID: 1386
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRHardwarePicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400056B RID: 1387
		public new static readonly string MRClassNameKey = "class vtkVRHardwarePicker";
	}
}
