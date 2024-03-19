using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRVelodyneReader
	///
	///
	/// A concrete instance of vtkAMRBaseReader that implements functionality
	/// for reading Velodyne AMR datasets.
	/// </summary>
	// Token: 0x0200022C RID: 556
	public class vtkAMRVelodyneReader : vtkAMRBaseReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006823 RID: 26659 RVA: 0x000967EF File Offset: 0x000949EF
		static vtkAMRVelodyneReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRVelodyneReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRVelodyneReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006824 RID: 26660 RVA: 0x00096817 File Offset: 0x00094A17
		public vtkAMRVelodyneReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006825 RID: 26661
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRVelodyneReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006826 RID: 26662 RVA: 0x00096828 File Offset: 0x00094A28
		public new static vtkAMRVelodyneReader New()
		{
			vtkAMRVelodyneReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRVelodyneReader.vtkAMRVelodyneReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRVelodyneReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006827 RID: 26663 RVA: 0x0009687C File Offset: 0x00094A7C
		public vtkAMRVelodyneReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRVelodyneReader.vtkAMRVelodyneReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006828 RID: 26664 RVA: 0x000968C0 File Offset: 0x00094AC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006829 RID: 26665
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRVelodyneReader_GetNumberOfBlocks_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600682A RID: 26666 RVA: 0x000968CC File Offset: 0x00094ACC
		public override int GetNumberOfBlocks()
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_GetNumberOfBlocks_01(base.GetCppThis());
		}

		// Token: 0x0600682B RID: 26667
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRVelodyneReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600682C RID: 26668 RVA: 0x000968EC File Offset: 0x00094AEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600682D RID: 26669
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRVelodyneReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600682E RID: 26670 RVA: 0x0009690C File Offset: 0x00094B0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600682F RID: 26671
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRVelodyneReader_GetNumberOfLevels_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006830 RID: 26672 RVA: 0x00096928 File Offset: 0x00094B28
		public override int GetNumberOfLevels()
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_GetNumberOfLevels_04(base.GetCppThis());
		}

		// Token: 0x06006831 RID: 26673
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRVelodyneReader_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006832 RID: 26674 RVA: 0x00096948 File Offset: 0x00094B48
		public new vtkOverlappingAMR GetOutput()
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRVelodyneReader.vtkAMRVelodyneReader_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x06006833 RID: 26675
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRVelodyneReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006834 RID: 26676 RVA: 0x000969B8 File Offset: 0x00094BB8
		public override int IsA(string type)
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06006835 RID: 26677
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRVelodyneReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006836 RID: 26678 RVA: 0x000969D8 File Offset: 0x00094BD8
		public new static int IsTypeOf(string type)
		{
			return vtkAMRVelodyneReader.vtkAMRVelodyneReader_IsTypeOf_07(type);
		}

		// Token: 0x06006837 RID: 26679
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRVelodyneReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006838 RID: 26680 RVA: 0x000969F4 File Offset: 0x00094BF4
		public new vtkAMRVelodyneReader NewInstance()
		{
			vtkAMRVelodyneReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRVelodyneReader.vtkAMRVelodyneReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRVelodyneReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006839 RID: 26681
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRVelodyneReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600683A RID: 26682 RVA: 0x00096A50 File Offset: 0x00094C50
		public new static vtkAMRVelodyneReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMRVelodyneReader vtkAMRVelodyneReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRVelodyneReader.vtkAMRVelodyneReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRVelodyneReader = (vtkAMRVelodyneReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRVelodyneReader.Register(null);
				}
			}
			return vtkAMRVelodyneReader;
		}

		// Token: 0x0600683B RID: 26683
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRVelodyneReader_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600683C RID: 26684 RVA: 0x00096ACF File Offset: 0x00094CCF
		public override void SetFileName(string fileName)
		{
			vtkAMRVelodyneReader.vtkAMRVelodyneReader_SetFileName_11(base.GetCppThis(), fileName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093F RID: 2367
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRVelodyneReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000940 RID: 2368
		public new static readonly string MRClassNameKey = "class vtkAMRVelodyneReader";
	}
}
