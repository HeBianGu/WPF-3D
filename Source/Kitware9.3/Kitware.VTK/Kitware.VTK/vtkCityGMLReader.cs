using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCityGMLReader
	/// </summary>
	/// <remarks>
	///    read CityGML data file
	///
	/// </remarks>
	// Token: 0x020001CA RID: 458
	public class vtkCityGMLReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060058DB RID: 22747 RVA: 0x000802D3 File Offset: 0x0007E4D3
		static vtkCityGMLReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCityGMLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCityGMLReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060058DC RID: 22748 RVA: 0x000802FB File Offset: 0x0007E4FB
		public vtkCityGMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060058DD RID: 22749
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCityGMLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058DE RID: 22750 RVA: 0x0008030C File Offset: 0x0007E50C
		public new static vtkCityGMLReader New()
		{
			vtkCityGMLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCityGMLReader.vtkCityGMLReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058DF RID: 22751 RVA: 0x00080360 File Offset: 0x0007E560
		public vtkCityGMLReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCityGMLReader.vtkCityGMLReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060058E0 RID: 22752 RVA: 0x000803A4 File Offset: 0x0007E5A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060058E1 RID: 22753
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetBeginBuildingIndex_01(HandleRef pThis);

		/// <summary>
		/// Read a range of buildings from the file [begin, end)
		/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
		/// will read all buildings from the file.
		/// </summary>
		// Token: 0x060058E2 RID: 22754 RVA: 0x000803B0 File Offset: 0x0007E5B0
		public virtual int GetBeginBuildingIndex()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetBeginBuildingIndex_01(base.GetCppThis());
		}

		// Token: 0x060058E3 RID: 22755
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetEndBuildingIndex_02(HandleRef pThis);

		/// <summary>
		/// Read a range of buildings from the file [begin, end)
		/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
		/// will read all buildings from the file.
		/// </summary>
		// Token: 0x060058E4 RID: 22756 RVA: 0x000803D0 File Offset: 0x0007E5D0
		public virtual int GetEndBuildingIndex()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetEndBuildingIndex_02(base.GetCppThis());
		}

		// Token: 0x060058E5 RID: 22757
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCityGMLReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify file name of the CityGML data file to read.
		/// </summary>
		// Token: 0x060058E6 RID: 22758 RVA: 0x000803F0 File Offset: 0x0007E5F0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCityGMLReader.vtkCityGMLReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060058E7 RID: 22759
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetLOD_04(HandleRef pThis);

		/// <summary>
		/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
		/// through 4 (most detailed), default value is 3.
		/// </summary>
		// Token: 0x060058E8 RID: 22760 RVA: 0x0008042C File Offset: 0x0007E62C
		public virtual int GetLOD()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetLOD_04(base.GetCppThis());
		}

		// Token: 0x060058E9 RID: 22761
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetLODMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
		/// through 4 (most detailed), default value is 3.
		/// </summary>
		// Token: 0x060058EA RID: 22762 RVA: 0x0008044C File Offset: 0x0007E64C
		public virtual int GetLODMaxValue()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetLODMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060058EB RID: 22763
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetLODMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
		/// through 4 (most detailed), default value is 3.
		/// </summary>
		// Token: 0x060058EC RID: 22764 RVA: 0x0008046C File Offset: 0x0007E66C
		public virtual int GetLODMinValue()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetLODMinValue_06(base.GetCppThis());
		}

		// Token: 0x060058ED RID: 22765
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetNumberOfBuildings_07(HandleRef pThis);

		/// <summary>
		/// Number of buildings read from the file.
		/// Default is numeric_limits&lt;int&gt;::max() which means the reader will read all
		/// buildings from the file. You can set either NumberOfBuidlings to read the range
		/// [0, NumberOfBuildings) or you can set BeginBuildingIndex and EndBuildingIndex to
		/// read the range [BeginBuildingIndex, EndBuildingIndex). If you send them both,
		/// a warning will be printed and we'll use the latter.
		/// </summary>
		// Token: 0x060058EE RID: 22766 RVA: 0x0008048C File Offset: 0x0007E68C
		public virtual int GetNumberOfBuildings()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetNumberOfBuildings_07(base.GetCppThis());
		}

		// Token: 0x060058EF RID: 22767
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCityGMLReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058F0 RID: 22768 RVA: 0x000804AC File Offset: 0x0007E6AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060058F1 RID: 22769
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCityGMLReader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058F2 RID: 22770 RVA: 0x000804CC File Offset: 0x0007E6CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060058F3 RID: 22771
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_GetUseTransparencyAsOpacity_10(HandleRef pThis);

		/// <summary>
		/// Certain input files use app:transparency as opacity. Set this field true
		/// to show that correctly. The default is false.
		/// </summary>
		// Token: 0x060058F4 RID: 22772 RVA: 0x000804E8 File Offset: 0x0007E6E8
		public virtual int GetUseTransparencyAsOpacity()
		{
			return vtkCityGMLReader.vtkCityGMLReader_GetUseTransparencyAsOpacity_10(base.GetCppThis());
		}

		// Token: 0x060058F5 RID: 22773
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058F6 RID: 22774 RVA: 0x00080508 File Offset: 0x0007E708
		public override int IsA(string type)
		{
			return vtkCityGMLReader.vtkCityGMLReader_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060058F7 RID: 22775
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCityGMLReader_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058F8 RID: 22776 RVA: 0x00080528 File Offset: 0x0007E728
		public new static int IsTypeOf(string type)
		{
			return vtkCityGMLReader.vtkCityGMLReader_IsTypeOf_12(type);
		}

		// Token: 0x060058F9 RID: 22777
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCityGMLReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058FA RID: 22778 RVA: 0x00080544 File Offset: 0x0007E744
		public new vtkCityGMLReader NewInstance()
		{
			vtkCityGMLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCityGMLReader.vtkCityGMLReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060058FB RID: 22779
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCityGMLReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060058FC RID: 22780 RVA: 0x000805A0 File Offset: 0x0007E7A0
		public new static vtkCityGMLReader SafeDownCast(vtkObjectBase o)
		{
			vtkCityGMLReader vtkCityGMLReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCityGMLReader.vtkCityGMLReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCityGMLReader = (vtkCityGMLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCityGMLReader.Register(null);
				}
			}
			return vtkCityGMLReader;
		}

		// Token: 0x060058FD RID: 22781
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetBeginBuildingIndex_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Read a range of buildings from the file [begin, end)
		/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
		/// will read all buildings from the file.
		/// </summary>
		// Token: 0x060058FE RID: 22782 RVA: 0x0008061F File Offset: 0x0007E81F
		public virtual void SetBeginBuildingIndex(int _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetBeginBuildingIndex_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060058FF RID: 22783
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetEndBuildingIndex_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Read a range of buildings from the file [begin, end)
		/// Default is begin=0, end = numeric_limits&lt;int&gt;::max() which means the reader
		/// will read all buildings from the file.
		/// </summary>
		// Token: 0x06005900 RID: 22784 RVA: 0x0008062F File Offset: 0x0007E82F
		public virtual void SetEndBuildingIndex(int _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetEndBuildingIndex_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06005901 RID: 22785
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of the CityGML data file to read.
		/// </summary>
		// Token: 0x06005902 RID: 22786 RVA: 0x0008063F File Offset: 0x0007E83F
		public virtual void SetFileName(string _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetFileName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06005903 RID: 22787
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetLOD_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the level of detail (LOD) to read. Valid values are from 0 (least detailed)
		/// through 4 (most detailed), default value is 3.
		/// </summary>
		// Token: 0x06005904 RID: 22788 RVA: 0x0008064F File Offset: 0x0007E84F
		public virtual void SetLOD(int _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetLOD_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06005905 RID: 22789
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetNumberOfBuildings_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Number of buildings read from the file.
		/// Default is numeric_limits&lt;int&gt;::max() which means the reader will read all
		/// buildings from the file. You can set either NumberOfBuidlings to read the range
		/// [0, NumberOfBuildings) or you can set BeginBuildingIndex and EndBuildingIndex to
		/// read the range [BeginBuildingIndex, EndBuildingIndex). If you send them both,
		/// a warning will be printed and we'll use the latter.
		/// </summary>
		// Token: 0x06005906 RID: 22790 RVA: 0x0008065F File Offset: 0x0007E85F
		public virtual void SetNumberOfBuildings(int _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetNumberOfBuildings_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06005907 RID: 22791
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_SetUseTransparencyAsOpacity_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Certain input files use app:transparency as opacity. Set this field true
		/// to show that correctly. The default is false.
		/// </summary>
		// Token: 0x06005908 RID: 22792 RVA: 0x0008066F File Offset: 0x0007E86F
		public virtual void SetUseTransparencyAsOpacity(int _arg)
		{
			vtkCityGMLReader.vtkCityGMLReader_SetUseTransparencyAsOpacity_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06005909 RID: 22793
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_UseTransparencyAsOpacityOff_22(HandleRef pThis);

		/// <summary>
		/// Certain input files use app:transparency as opacity. Set this field true
		/// to show that correctly. The default is false.
		/// </summary>
		// Token: 0x0600590A RID: 22794 RVA: 0x0008067F File Offset: 0x0007E87F
		public virtual void UseTransparencyAsOpacityOff()
		{
			vtkCityGMLReader.vtkCityGMLReader_UseTransparencyAsOpacityOff_22(base.GetCppThis());
		}

		// Token: 0x0600590B RID: 22795
		[DllImport("Kitware.VTK.IOCityGML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCityGMLReader_UseTransparencyAsOpacityOn_23(HandleRef pThis);

		/// <summary>
		/// Certain input files use app:transparency as opacity. Set this field true
		/// to show that correctly. The default is false.
		/// </summary>
		// Token: 0x0600590C RID: 22796 RVA: 0x0008068E File Offset: 0x0007E88E
		public virtual void UseTransparencyAsOpacityOn()
		{
			vtkCityGMLReader.vtkCityGMLReader_UseTransparencyAsOpacityOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085B RID: 2139
		public new const string MRFullTypeName = "Kitware.VTK.vtkCityGMLReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085C RID: 2140
		public new static readonly string MRClassNameKey = "class vtkCityGMLReader";
	}
}
