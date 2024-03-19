using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000032 RID: 50
	public class vtkDICOMSorter : vtkDICOMFileSorter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000871 RID: 2161 RVA: 0x0001371C File Offset: 0x0001191C
		static vtkDICOMSorter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMSorter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSorter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000872 RID: 2162 RVA: 0x00013744 File Offset: 0x00011944
		public vtkDICOMSorter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000873 RID: 2163
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSorter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000874 RID: 2164 RVA: 0x00013754 File Offset: 0x00011954
		public new static vtkDICOMSorter New()
		{
			vtkDICOMSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSorter.vtkDICOMSorter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000137A8 File Offset: 0x000119A8
		public vtkDICOMSorter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMSorter.vtkDICOMSorter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000876 RID: 2166 RVA: 0x000137EC File Offset: 0x000119EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000877 RID: 2167
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSorter_GetFirstSeriesInStudy_01(HandleRef pThis, int study);

		// Token: 0x06000878 RID: 2168 RVA: 0x000137F8 File Offset: 0x000119F8
		public int GetFirstSeriesInStudy(int study)
		{
			return vtkDICOMSorter.vtkDICOMSorter_GetFirstSeriesInStudy_01(base.GetCppThis(), study);
		}

		// Token: 0x06000879 RID: 2169
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSorter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600087A RID: 2170 RVA: 0x00013818 File Offset: 0x00011A18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMSorter.vtkDICOMSorter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600087B RID: 2171
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSorter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600087C RID: 2172 RVA: 0x00013838 File Offset: 0x00011A38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMSorter.vtkDICOMSorter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600087D RID: 2173
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSorter_GetNumberOfSeriesInStudy_04(HandleRef pThis, int study);

		// Token: 0x0600087E RID: 2174 RVA: 0x00013854 File Offset: 0x00011A54
		public int GetNumberOfSeriesInStudy(int study)
		{
			return vtkDICOMSorter.vtkDICOMSorter_GetNumberOfSeriesInStudy_04(base.GetCppThis(), study);
		}

		// Token: 0x0600087F RID: 2175
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSorter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000880 RID: 2176 RVA: 0x00013874 File Offset: 0x00011A74
		public override int IsA(string type)
		{
			return vtkDICOMSorter.vtkDICOMSorter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06000881 RID: 2177
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSorter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000882 RID: 2178 RVA: 0x00013894 File Offset: 0x00011A94
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMSorter.vtkDICOMSorter_IsTypeOf_06(type);
		}

		// Token: 0x06000883 RID: 2179
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSorter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000884 RID: 2180 RVA: 0x000138B0 File Offset: 0x00011AB0
		public new vtkDICOMSorter NewInstance()
		{
			vtkDICOMSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSorter.vtkDICOMSorter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000885 RID: 2181
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSorter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000886 RID: 2182 RVA: 0x0001390C File Offset: 0x00011B0C
		public new static vtkDICOMSorter SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMSorter vtkDICOMSorter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSorter.vtkDICOMSorter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMSorter = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMSorter.Register(null);
				}
			}
			return vtkDICOMSorter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038E RID: 910
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSorter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038F RID: 911
		public new static readonly string MRClassNameKey = "class vtkDICOMSorter";
	}
}
