using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAMReXGridReader
	/// </summary>
	/// <remarks>
	///  reader for AMReX plotfiles grid data.
	///
	/// vtkAMReXGridReader readers grid data from AMReX plotfiles.
	/// </remarks>
	// Token: 0x02000228 RID: 552
	public class vtkAMReXGridReader : vtkAMRBaseReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060067BD RID: 26557 RVA: 0x00095CC7 File Offset: 0x00093EC7
		static vtkAMReXGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMReXGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMReXGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060067BE RID: 26558 RVA: 0x00095CEF File Offset: 0x00093EEF
		public vtkAMReXGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060067BF RID: 26559
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067C0 RID: 26560 RVA: 0x00095D00 File Offset: 0x00093F00
		public new static vtkAMReXGridReader New()
		{
			vtkAMReXGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXGridReader.vtkAMReXGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMReXGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067C1 RID: 26561 RVA: 0x00095D54 File Offset: 0x00093F54
		public vtkAMReXGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMReXGridReader.vtkAMReXGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060067C2 RID: 26562 RVA: 0x00095D98 File Offset: 0x00093F98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060067C3 RID: 26563
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXGridReader_GetNumberOfBlocks_01(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfBlocks
		/// </summary>
		// Token: 0x060067C4 RID: 26564 RVA: 0x00095DA4 File Offset: 0x00093FA4
		public override int GetNumberOfBlocks()
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_GetNumberOfBlocks_01(base.GetCppThis());
		}

		// Token: 0x060067C5 RID: 26565
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMReXGridReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067C6 RID: 26566 RVA: 0x00095DC4 File Offset: 0x00093FC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060067C7 RID: 26567
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMReXGridReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067C8 RID: 26568 RVA: 0x00095DE4 File Offset: 0x00093FE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060067C9 RID: 26569
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXGridReader_GetNumberOfLevels_04(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfLevels
		/// </summary>
		// Token: 0x060067CA RID: 26570 RVA: 0x00095E00 File Offset: 0x00094000
		public override int GetNumberOfLevels()
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_GetNumberOfLevels_04(base.GetCppThis());
		}

		// Token: 0x060067CB RID: 26571
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067CC RID: 26572 RVA: 0x00095E20 File Offset: 0x00094020
		public override int IsA(string type)
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060067CD RID: 26573
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMReXGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067CE RID: 26574 RVA: 0x00095E40 File Offset: 0x00094040
		public new static int IsTypeOf(string type)
		{
			return vtkAMReXGridReader.vtkAMReXGridReader_IsTypeOf_06(type);
		}

		// Token: 0x060067CF RID: 26575
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067D0 RID: 26576 RVA: 0x00095E5C File Offset: 0x0009405C
		public new vtkAMReXGridReader NewInstance()
		{
			vtkAMReXGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXGridReader.vtkAMReXGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMReXGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060067D1 RID: 26577
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMReXGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067D2 RID: 26578 RVA: 0x00095EB8 File Offset: 0x000940B8
		public new static vtkAMReXGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMReXGridReader vtkAMReXGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMReXGridReader.vtkAMReXGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMReXGridReader = (vtkAMReXGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMReXGridReader.Register(null);
				}
			}
			return vtkAMReXGridReader;
		}

		// Token: 0x060067D3 RID: 26579
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMReXGridReader_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// See vtkAMRBaseReader::SetFileName
		/// </summary>
		// Token: 0x060067D4 RID: 26580 RVA: 0x00095F37 File Offset: 0x00094137
		public override void SetFileName(string fileName)
		{
			vtkAMReXGridReader.vtkAMReXGridReader_SetFileName_10(base.GetCppThis(), fileName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000937 RID: 2359
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMReXGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000938 RID: 2360
		public new static readonly string MRClassNameKey = "class vtkAMReXGridReader";
	}
}
