using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEarthSource
	/// </summary>
	/// <remarks>
	///    create the continents of the Earth as a sphere
	///
	/// vtkEarthSource creates a spherical rendering of the geographical shapes
	/// of the major continents of the earth. The OnRatio determines
	/// how much of the data is actually used. The radius defines the radius
	/// of the sphere at which the continents are placed. Obtains data from
	/// an embedded array of coordinates.
	/// </remarks>
	// Token: 0x02000608 RID: 1544
	public class vtkEarthSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010C2A RID: 68650 RVA: 0x0017612B File Offset: 0x0017432B
		static vtkEarthSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEarthSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEarthSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010C2B RID: 68651 RVA: 0x00176153 File Offset: 0x00174353
		public vtkEarthSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010C2C RID: 68652
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEarthSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C2D RID: 68653 RVA: 0x00176164 File Offset: 0x00174364
		public new static vtkEarthSource New()
		{
			vtkEarthSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C2E RID: 68654 RVA: 0x001761B8 File Offset: 0x001743B8
		public vtkEarthSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEarthSource.vtkEarthSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010C2F RID: 68655 RVA: 0x001761FC File Offset: 0x001743FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010C30 RID: 68656
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEarthSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C31 RID: 68657 RVA: 0x00176208 File Offset: 0x00174408
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEarthSource.vtkEarthSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010C32 RID: 68658
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEarthSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C33 RID: 68659 RVA: 0x00176228 File Offset: 0x00174428
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEarthSource.vtkEarthSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010C34 RID: 68660
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_GetOnRatio_03(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity. This controls how much detail the model
		/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
		/// detail there is.)
		/// </summary>
		// Token: 0x06010C35 RID: 68661 RVA: 0x00176244 File Offset: 0x00174444
		public virtual int GetOnRatio()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatio_03(base.GetCppThis());
		}

		// Token: 0x06010C36 RID: 68662
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_GetOnRatioMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity. This controls how much detail the model
		/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
		/// detail there is.)
		/// </summary>
		// Token: 0x06010C37 RID: 68663 RVA: 0x00176264 File Offset: 0x00174464
		public virtual int GetOnRatioMaxValue()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatioMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06010C38 RID: 68664
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_GetOnRatioMinValue_05(HandleRef pThis);

		/// <summary>
		/// Turn on every nth entity. This controls how much detail the model
		/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
		/// detail there is.)
		/// </summary>
		// Token: 0x06010C39 RID: 68665 RVA: 0x00176284 File Offset: 0x00174484
		public virtual int GetOnRatioMinValue()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatioMinValue_05(base.GetCppThis());
		}

		// Token: 0x06010C3A RID: 68666
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_GetOutline_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
		/// Warning: some graphics systems will have trouble with the very large, concave
		/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
		/// for now.
		/// </summary>
		// Token: 0x06010C3B RID: 68667 RVA: 0x001762A4 File Offset: 0x001744A4
		public virtual int GetOutline()
		{
			return vtkEarthSource.vtkEarthSource_GetOutline_06(base.GetCppThis());
		}

		// Token: 0x06010C3C RID: 68668
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEarthSource_GetRadius_07(HandleRef pThis);

		/// <summary>
		/// Set radius of earth.
		/// </summary>
		// Token: 0x06010C3D RID: 68669 RVA: 0x001762C4 File Offset: 0x001744C4
		public virtual double GetRadius()
		{
			return vtkEarthSource.vtkEarthSource_GetRadius_07(base.GetCppThis());
		}

		// Token: 0x06010C3E RID: 68670
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEarthSource_GetRadiusMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set radius of earth.
		/// </summary>
		// Token: 0x06010C3F RID: 68671 RVA: 0x001762E4 File Offset: 0x001744E4
		public virtual double GetRadiusMaxValue()
		{
			return vtkEarthSource.vtkEarthSource_GetRadiusMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06010C40 RID: 68672
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEarthSource_GetRadiusMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set radius of earth.
		/// </summary>
		// Token: 0x06010C41 RID: 68673 RVA: 0x00176304 File Offset: 0x00174504
		public virtual double GetRadiusMinValue()
		{
			return vtkEarthSource.vtkEarthSource_GetRadiusMinValue_09(base.GetCppThis());
		}

		// Token: 0x06010C42 RID: 68674
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C43 RID: 68675 RVA: 0x00176324 File Offset: 0x00174524
		public override int IsA(string type)
		{
			return vtkEarthSource.vtkEarthSource_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06010C44 RID: 68676
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEarthSource_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C45 RID: 68677 RVA: 0x00176344 File Offset: 0x00174544
		public new static int IsTypeOf(string type)
		{
			return vtkEarthSource.vtkEarthSource_IsTypeOf_11(type);
		}

		// Token: 0x06010C46 RID: 68678
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEarthSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C47 RID: 68679 RVA: 0x00176360 File Offset: 0x00174560
		public new vtkEarthSource NewInstance()
		{
			vtkEarthSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010C48 RID: 68680
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEarthSource_OutlineOff_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
		/// Warning: some graphics systems will have trouble with the very large, concave
		/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
		/// for now.
		/// </summary>
		// Token: 0x06010C49 RID: 68681 RVA: 0x001763BA File Offset: 0x001745BA
		public virtual void OutlineOff()
		{
			vtkEarthSource.vtkEarthSource_OutlineOff_14(base.GetCppThis());
		}

		// Token: 0x06010C4A RID: 68682
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEarthSource_OutlineOn_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
		/// Warning: some graphics systems will have trouble with the very large, concave
		/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
		/// for now.
		/// </summary>
		// Token: 0x06010C4B RID: 68683 RVA: 0x001763C9 File Offset: 0x001745C9
		public virtual void OutlineOn()
		{
			vtkEarthSource.vtkEarthSource_OutlineOn_15(base.GetCppThis());
		}

		// Token: 0x06010C4C RID: 68684
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEarthSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010C4D RID: 68685 RVA: 0x001763D8 File Offset: 0x001745D8
		public new static vtkEarthSource SafeDownCast(vtkObjectBase o)
		{
			vtkEarthSource vtkEarthSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEarthSource = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEarthSource.Register(null);
				}
			}
			return vtkEarthSource;
		}

		// Token: 0x06010C4E RID: 68686
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEarthSource_SetOnRatio_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on every nth entity. This controls how much detail the model
		/// will have. The maximum ratio is sixteen. (The smaller OnRatio, the more
		/// detail there is.)
		/// </summary>
		// Token: 0x06010C4F RID: 68687 RVA: 0x00176457 File Offset: 0x00174657
		public virtual void SetOnRatio(int _arg)
		{
			vtkEarthSource.vtkEarthSource_SetOnRatio_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06010C50 RID: 68688
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEarthSource_SetOutline_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off drawing continents as filled polygons or as wireframe outlines.
		/// Warning: some graphics systems will have trouble with the very large, concave
		/// filled polygons. Recommend you use OutlienOn (i.e., disable filled polygons)
		/// for now.
		/// </summary>
		// Token: 0x06010C51 RID: 68689 RVA: 0x00176467 File Offset: 0x00174667
		public virtual void SetOutline(int _arg)
		{
			vtkEarthSource.vtkEarthSource_SetOutline_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06010C52 RID: 68690
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEarthSource_SetRadius_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set radius of earth.
		/// </summary>
		// Token: 0x06010C53 RID: 68691 RVA: 0x00176477 File Offset: 0x00174677
		public virtual void SetRadius(double _arg)
		{
			vtkEarthSource.vtkEarthSource_SetRadius_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136A RID: 4970
		public new const string MRFullTypeName = "Kitware.VTK.vtkEarthSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400136B RID: 4971
		public new static readonly string MRClassNameKey = "class vtkEarthSource";
	}
}
