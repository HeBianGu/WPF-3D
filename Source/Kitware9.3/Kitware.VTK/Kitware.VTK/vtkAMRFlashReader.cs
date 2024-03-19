using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMREnzoReader
	/// </summary>
	/// <remarks>
	///    A concrete instance of vtkAMRBaseReader that implements functionality
	/// for reading Flash AMR datasets.
	/// </remarks>
	// Token: 0x0200022B RID: 555
	public class vtkAMRFlashReader : vtkAMRBaseReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600680B RID: 26635 RVA: 0x0009656F File Offset: 0x0009476F
		static vtkAMRFlashReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRFlashReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRFlashReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600680C RID: 26636 RVA: 0x00096597 File Offset: 0x00094797
		public vtkAMRFlashReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600680D RID: 26637
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600680E RID: 26638 RVA: 0x000965A8 File Offset: 0x000947A8
		public new static vtkAMRFlashReader New()
		{
			vtkAMRFlashReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashReader.vtkAMRFlashReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRFlashReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600680F RID: 26639 RVA: 0x000965FC File Offset: 0x000947FC
		public vtkAMRFlashReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRFlashReader.vtkAMRFlashReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006810 RID: 26640 RVA: 0x00096640 File Offset: 0x00094840
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006811 RID: 26641
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashReader_GetNumberOfBlocks_01(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfBlocks
		/// </summary>
		// Token: 0x06006812 RID: 26642 RVA: 0x0009664C File Offset: 0x0009484C
		public override int GetNumberOfBlocks()
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_GetNumberOfBlocks_01(base.GetCppThis());
		}

		// Token: 0x06006813 RID: 26643
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRFlashReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006814 RID: 26644 RVA: 0x0009666C File Offset: 0x0009486C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006815 RID: 26645
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRFlashReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006816 RID: 26646 RVA: 0x0009668C File Offset: 0x0009488C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006817 RID: 26647
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashReader_GetNumberOfLevels_04(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseReader::GetNumberOfLevels
		/// </summary>
		// Token: 0x06006818 RID: 26648 RVA: 0x000966A8 File Offset: 0x000948A8
		public override int GetNumberOfLevels()
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_GetNumberOfLevels_04(base.GetCppThis());
		}

		// Token: 0x06006819 RID: 26649
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600681A RID: 26650 RVA: 0x000966C8 File Offset: 0x000948C8
		public override int IsA(string type)
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600681B RID: 26651
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600681C RID: 26652 RVA: 0x000966E8 File Offset: 0x000948E8
		public new static int IsTypeOf(string type)
		{
			return vtkAMRFlashReader.vtkAMRFlashReader_IsTypeOf_06(type);
		}

		// Token: 0x0600681D RID: 26653
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600681E RID: 26654 RVA: 0x00096704 File Offset: 0x00094904
		public new vtkAMRFlashReader NewInstance()
		{
			vtkAMRFlashReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashReader.vtkAMRFlashReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRFlashReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600681F RID: 26655
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006820 RID: 26656 RVA: 0x00096760 File Offset: 0x00094960
		public new static vtkAMRFlashReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMRFlashReader vtkAMRFlashReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashReader.vtkAMRFlashReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRFlashReader = (vtkAMRFlashReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRFlashReader.Register(null);
				}
			}
			return vtkAMRFlashReader;
		}

		// Token: 0x06006821 RID: 26657
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRFlashReader_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// See vtkAMRBaseReader::SetFileName
		/// </summary>
		// Token: 0x06006822 RID: 26658 RVA: 0x000967DF File Offset: 0x000949DF
		public override void SetFileName(string fileName)
		{
			vtkAMRFlashReader.vtkAMRFlashReader_SetFileName_10(base.GetCppThis(), fileName);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093D RID: 2365
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRFlashReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093E RID: 2366
		public new static readonly string MRClassNameKey = "class vtkAMRFlashReader";
	}
}
