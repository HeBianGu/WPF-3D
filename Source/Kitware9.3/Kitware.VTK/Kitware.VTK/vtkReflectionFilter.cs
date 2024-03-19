using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReflectionFilter
	/// </summary>
	/// <remarks>
	///    reflects a data set across a plane
	///
	/// The vtkReflectionFilter reflects a data set across one of the
	/// planes formed by the data set's bounding box.
	/// Since it converts data sets into unstructured grids, it is not efficient
	/// for structured data sets.
	/// </remarks>
	// Token: 0x0200052B RID: 1323
	public class vtkReflectionFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EC79 RID: 60537 RVA: 0x00149BEB File Offset: 0x00147DEB
		static vtkReflectionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReflectionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReflectionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC7A RID: 60538 RVA: 0x00149C13 File Offset: 0x00147E13
		public vtkReflectionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EC7B RID: 60539
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReflectionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC7C RID: 60540 RVA: 0x00149C24 File Offset: 0x00147E24
		public new static vtkReflectionFilter New()
		{
			vtkReflectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC7D RID: 60541 RVA: 0x00149C78 File Offset: 0x00147E78
		public vtkReflectionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReflectionFilter.vtkReflectionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC7E RID: 60542 RVA: 0x00149CBC File Offset: 0x00147EBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EC7F RID: 60543
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_CopyInputOff_01(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the reflection.
		/// </summary>
		// Token: 0x0600EC80 RID: 60544 RVA: 0x00149CC7 File Offset: 0x00147EC7
		public virtual void CopyInputOff()
		{
			vtkReflectionFilter.vtkReflectionFilter_CopyInputOff_01(base.GetCppThis());
		}

		// Token: 0x0600EC81 RID: 60545
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_CopyInputOn_02(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the reflection.
		/// </summary>
		// Token: 0x0600EC82 RID: 60546 RVA: 0x00149CD6 File Offset: 0x00147ED6
		public virtual void CopyInputOn()
		{
			vtkReflectionFilter.vtkReflectionFilter_CopyInputOn_02(base.GetCppThis());
		}

		// Token: 0x0600EC83 RID: 60547
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_FlipAllInputArraysOff_03(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors, Normals and Tensors will be flipped.
		/// If on, all 3-component data arrays ( considered as 3D vectors),
		/// 6-component data arrays (considered as symmetric tensors),
		/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
		/// All other won't be flipped and will only be copied.
		/// </summary>
		// Token: 0x0600EC84 RID: 60548 RVA: 0x00149CE5 File Offset: 0x00147EE5
		public virtual void FlipAllInputArraysOff()
		{
			vtkReflectionFilter.vtkReflectionFilter_FlipAllInputArraysOff_03(base.GetCppThis());
		}

		// Token: 0x0600EC85 RID: 60549
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_FlipAllInputArraysOn_04(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors, Normals and Tensors will be flipped.
		/// If on, all 3-component data arrays ( considered as 3D vectors),
		/// 6-component data arrays (considered as symmetric tensors),
		/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
		/// All other won't be flipped and will only be copied.
		/// </summary>
		// Token: 0x0600EC86 RID: 60550 RVA: 0x00149CF4 File Offset: 0x00147EF4
		public virtual void FlipAllInputArraysOn()
		{
			vtkReflectionFilter.vtkReflectionFilter_FlipAllInputArraysOn_04(base.GetCppThis());
		}

		// Token: 0x0600EC87 RID: 60551
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkReflectionFilter_GetCenter_05(HandleRef pThis);

		/// <summary>
		/// If the reflection plane is set to X, Y or Z, this variable
		/// is use to set the position of the plane.
		/// </summary>
		// Token: 0x0600EC88 RID: 60552 RVA: 0x00149D04 File Offset: 0x00147F04
		public virtual double GetCenter()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetCenter_05(base.GetCppThis());
		}

		// Token: 0x0600EC89 RID: 60553
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_GetCopyInput_06(HandleRef pThis);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the reflection.
		/// </summary>
		// Token: 0x0600EC8A RID: 60554 RVA: 0x00149D24 File Offset: 0x00147F24
		public virtual int GetCopyInput()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetCopyInput_06(base.GetCppThis());
		}

		// Token: 0x0600EC8B RID: 60555
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkReflectionFilter_GetFlipAllInputArrays_07(HandleRef pThis);

		/// <summary>
		/// If off (the default), only Vectors, Normals and Tensors will be flipped.
		/// If on, all 3-component data arrays ( considered as 3D vectors),
		/// 6-component data arrays (considered as symmetric tensors),
		/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
		/// All other won't be flipped and will only be copied.
		/// </summary>
		// Token: 0x0600EC8C RID: 60556 RVA: 0x00149D44 File Offset: 0x00147F44
		public virtual bool GetFlipAllInputArrays()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetFlipAllInputArrays_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600EC8D RID: 60557
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReflectionFilter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC8E RID: 60558 RVA: 0x00149D6C File Offset: 0x00147F6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600EC8F RID: 60559
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReflectionFilter_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC90 RID: 60560 RVA: 0x00149D8C File Offset: 0x00147F8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600EC91 RID: 60561
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_GetPlane_10(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600EC92 RID: 60562 RVA: 0x00149DA8 File Offset: 0x00147FA8
		public virtual int GetPlane()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlane_10(base.GetCppThis());
		}

		// Token: 0x0600EC93 RID: 60563
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_GetPlaneMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600EC94 RID: 60564 RVA: 0x00149DC8 File Offset: 0x00147FC8
		public virtual int GetPlaneMaxValue()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlaneMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600EC95 RID: 60565
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_GetPlaneMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600EC96 RID: 60566 RVA: 0x00149DE8 File Offset: 0x00147FE8
		public virtual int GetPlaneMinValue()
		{
			return vtkReflectionFilter.vtkReflectionFilter_GetPlaneMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600EC97 RID: 60567
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC98 RID: 60568 RVA: 0x00149E08 File Offset: 0x00148008
		public override int IsA(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600EC99 RID: 60569
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReflectionFilter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC9A RID: 60570 RVA: 0x00149E28 File Offset: 0x00148028
		public new static int IsTypeOf(string type)
		{
			return vtkReflectionFilter.vtkReflectionFilter_IsTypeOf_14(type);
		}

		// Token: 0x0600EC9B RID: 60571
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReflectionFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC9C RID: 60572 RVA: 0x00149E44 File Offset: 0x00148044
		public new vtkReflectionFilter NewInstance()
		{
			vtkReflectionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EC9D RID: 60573
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReflectionFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC9E RID: 60574 RVA: 0x00149EA0 File Offset: 0x001480A0
		public new static vtkReflectionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkReflectionFilter vtkReflectionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReflectionFilter.vtkReflectionFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReflectionFilter = (vtkReflectionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReflectionFilter.Register(null);
				}
			}
			return vtkReflectionFilter;
		}

		// Token: 0x0600EC9F RID: 60575
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetCenter_18(HandleRef pThis, double _arg);

		/// <summary>
		/// If the reflection plane is set to X, Y or Z, this variable
		/// is use to set the position of the plane.
		/// </summary>
		// Token: 0x0600ECA0 RID: 60576 RVA: 0x00149F1F File Offset: 0x0014811F
		public virtual void SetCenter(double _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetCenter_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECA1 RID: 60577
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetCopyInput_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If on (the default), copy the input geometry to the output. If off,
		/// the output will only contain the reflection.
		/// </summary>
		// Token: 0x0600ECA2 RID: 60578 RVA: 0x00149F2F File Offset: 0x0014812F
		public virtual void SetCopyInput(int _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetCopyInput_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECA3 RID: 60579
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetFlipAllInputArrays_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// If off (the default), only Vectors, Normals and Tensors will be flipped.
		/// If on, all 3-component data arrays ( considered as 3D vectors),
		/// 6-component data arrays (considered as symmetric tensors),
		/// 9-component data arrays (considered as tensors ) of signed type will be flipped.
		/// All other won't be flipped and will only be copied.
		/// </summary>
		// Token: 0x0600ECA4 RID: 60580 RVA: 0x00149F3F File Offset: 0x0014813F
		public virtual void SetFlipAllInputArrays(bool _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetFlipAllInputArrays_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600ECA5 RID: 60581
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlane_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECA6 RID: 60582 RVA: 0x00149F57 File Offset: 0x00148157
		public virtual void SetPlane(int _arg)
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlane_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECA7 RID: 60583
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToX_22(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECA8 RID: 60584 RVA: 0x00149F67 File Offset: 0x00148167
		public void SetPlaneToX()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToX_22(base.GetCppThis());
		}

		// Token: 0x0600ECA9 RID: 60585
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToXMax_23(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECAA RID: 60586 RVA: 0x00149F76 File Offset: 0x00148176
		public void SetPlaneToXMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToXMax_23(base.GetCppThis());
		}

		// Token: 0x0600ECAB RID: 60587
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToXMin_24(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECAC RID: 60588 RVA: 0x00149F85 File Offset: 0x00148185
		public void SetPlaneToXMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToXMin_24(base.GetCppThis());
		}

		// Token: 0x0600ECAD RID: 60589
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToY_25(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECAE RID: 60590 RVA: 0x00149F94 File Offset: 0x00148194
		public void SetPlaneToY()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToY_25(base.GetCppThis());
		}

		// Token: 0x0600ECAF RID: 60591
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToYMax_26(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECB0 RID: 60592 RVA: 0x00149FA3 File Offset: 0x001481A3
		public void SetPlaneToYMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToYMax_26(base.GetCppThis());
		}

		// Token: 0x0600ECB1 RID: 60593
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToYMin_27(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECB2 RID: 60594 RVA: 0x00149FB2 File Offset: 0x001481B2
		public void SetPlaneToYMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToYMin_27(base.GetCppThis());
		}

		// Token: 0x0600ECB3 RID: 60595
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToZ_28(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECB4 RID: 60596 RVA: 0x00149FC1 File Offset: 0x001481C1
		public void SetPlaneToZ()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZ_28(base.GetCppThis());
		}

		// Token: 0x0600ECB5 RID: 60597
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToZMax_29(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECB6 RID: 60598 RVA: 0x00149FD0 File Offset: 0x001481D0
		public void SetPlaneToZMax()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZMax_29(base.GetCppThis());
		}

		// Token: 0x0600ECB7 RID: 60599
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReflectionFilter_SetPlaneToZMin_30(HandleRef pThis);

		/// <summary>
		/// Set the normal of the plane to use as mirror.
		/// </summary>
		// Token: 0x0600ECB8 RID: 60600 RVA: 0x00149FDF File Offset: 0x001481DF
		public void SetPlaneToZMin()
		{
			vtkReflectionFilter.vtkReflectionFilter_SetPlaneToZMin_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001145 RID: 4421
		public new const string MRFullTypeName = "Kitware.VTK.vtkReflectionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001146 RID: 4422
		public new static readonly string MRClassNameKey = "class vtkReflectionFilter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200052C RID: 1324
		public enum ReflectionPlane
		{
			/// <summary>enum member</summary>
			// Token: 0x04001148 RID: 4424
			USE_X = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001149 RID: 4425
			USE_X_MAX = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400114A RID: 4426
			USE_X_MIN = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400114B RID: 4427
			USE_Y = 7,
			/// <summary>enum member</summary>
			// Token: 0x0400114C RID: 4428
			USE_Y_MAX = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400114D RID: 4429
			USE_Y_MIN = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400114E RID: 4430
			USE_Z = 8,
			/// <summary>enum member</summary>
			// Token: 0x0400114F RID: 4431
			USE_Z_MAX = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001150 RID: 4432
			USE_Z_MIN = 2
		}
	}
}
