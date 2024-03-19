using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMREnzoReader
	///
	///
	/// A concrete instance of vtkAMRBaseReader that implements functionality
	/// for reading Enzo AMR datasets.
	/// </summary>
	// Token: 0x02000227 RID: 551
	public class vtkAMREnzoReader : vtkAMRBaseReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600679D RID: 26525 RVA: 0x000959F7 File Offset: 0x00093BF7
		static vtkAMREnzoReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMREnzoReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMREnzoReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600679E RID: 26526 RVA: 0x00095A1F File Offset: 0x00093C1F
		public vtkAMREnzoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600679F RID: 26527
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067A0 RID: 26528 RVA: 0x00095A30 File Offset: 0x00093C30
		public new static vtkAMREnzoReader New()
		{
			vtkAMREnzoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoReader.vtkAMREnzoReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMREnzoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067A1 RID: 26529 RVA: 0x00095A84 File Offset: 0x00093C84
		public vtkAMREnzoReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMREnzoReader.vtkAMREnzoReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060067A2 RID: 26530 RVA: 0x00095AC8 File Offset: 0x00093CC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060067A3 RID: 26531
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMREnzoReader_ConvertToCGSOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether data should be converted to CGS
		/// </summary>
		// Token: 0x060067A4 RID: 26532 RVA: 0x00095AD3 File Offset: 0x00093CD3
		public virtual void ConvertToCGSOff()
		{
			vtkAMREnzoReader.vtkAMREnzoReader_ConvertToCGSOff_01(base.GetCppThis());
		}

		// Token: 0x060067A5 RID: 26533
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMREnzoReader_ConvertToCGSOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether data should be converted to CGS
		/// </summary>
		// Token: 0x060067A6 RID: 26534 RVA: 0x00095AE2 File Offset: 0x00093CE2
		public virtual void ConvertToCGSOn()
		{
			vtkAMREnzoReader.vtkAMREnzoReader_ConvertToCGSOn_02(base.GetCppThis());
		}

		// Token: 0x060067A7 RID: 26535
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoReader_GetConvertToCGS_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether data should be converted to CGS
		/// </summary>
		// Token: 0x060067A8 RID: 26536 RVA: 0x00095AF4 File Offset: 0x00093CF4
		public virtual int GetConvertToCGS()
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_GetConvertToCGS_03(base.GetCppThis());
		}

		// Token: 0x060067A9 RID: 26537
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoReader_GetNumberOfBlocks_04(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfBlocks
		/// </summary>
		// Token: 0x060067AA RID: 26538 RVA: 0x00095B14 File Offset: 0x00093D14
		public override int GetNumberOfBlocks()
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_GetNumberOfBlocks_04(base.GetCppThis());
		}

		// Token: 0x060067AB RID: 26539
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMREnzoReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067AC RID: 26540 RVA: 0x00095B34 File Offset: 0x00093D34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060067AD RID: 26541
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMREnzoReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067AE RID: 26542 RVA: 0x00095B54 File Offset: 0x00093D54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060067AF RID: 26543
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoReader_GetNumberOfLevels_07(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfLevels
		/// </summary>
		// Token: 0x060067B0 RID: 26544 RVA: 0x00095B70 File Offset: 0x00093D70
		public override int GetNumberOfLevels()
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_GetNumberOfLevels_07(base.GetCppThis());
		}

		// Token: 0x060067B1 RID: 26545
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067B2 RID: 26546 RVA: 0x00095B90 File Offset: 0x00093D90
		public override int IsA(string type)
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060067B3 RID: 26547
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMREnzoReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067B4 RID: 26548 RVA: 0x00095BB0 File Offset: 0x00093DB0
		public new static int IsTypeOf(string type)
		{
			return vtkAMREnzoReader.vtkAMREnzoReader_IsTypeOf_09(type);
		}

		// Token: 0x060067B5 RID: 26549
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067B6 RID: 26550 RVA: 0x00095BCC File Offset: 0x00093DCC
		public new vtkAMREnzoReader NewInstance()
		{
			vtkAMREnzoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoReader.vtkAMREnzoReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMREnzoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060067B7 RID: 26551
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMREnzoReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067B8 RID: 26552 RVA: 0x00095C28 File Offset: 0x00093E28
		public new static vtkAMREnzoReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMREnzoReader vtkAMREnzoReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMREnzoReader.vtkAMREnzoReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMREnzoReader = (vtkAMREnzoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMREnzoReader.Register(null);
				}
			}
			return vtkAMREnzoReader;
		}

		// Token: 0x060067B9 RID: 26553
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMREnzoReader_SetConvertToCGS_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether data should be converted to CGS
		/// </summary>
		// Token: 0x060067BA RID: 26554 RVA: 0x00095CA7 File Offset: 0x00093EA7
		public virtual void SetConvertToCGS(int _arg)
		{
			vtkAMREnzoReader.vtkAMREnzoReader_SetConvertToCGS_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060067BB RID: 26555
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMREnzoReader_SetFileName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// See vtkAMRBaseReader::SetFileName
		/// </summary>
		// Token: 0x060067BC RID: 26556 RVA: 0x00095CB7 File Offset: 0x00093EB7
		public override void SetFileName(string fileName)
		{
			vtkAMREnzoReader.vtkAMREnzoReader_SetFileName_14(base.GetCppThis(), fileName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000935 RID: 2357
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMREnzoReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000936 RID: 2358
		public new static readonly string MRClassNameKey = "class vtkAMREnzoReader";
	}
}
