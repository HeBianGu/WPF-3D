using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMRCReader
	/// </summary>
	/// <remarks>
	///    read MRC image files
	///
	///
	/// A reader to load MRC images.  See http://bio3d.colorado.edu/imod/doc/mrc_format.txt
	/// for the file format specification.
	/// </remarks>
	// Token: 0x0200078F RID: 1935
	public class vtkMRCReader : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013E74 RID: 81524 RVA: 0x001C2006 File Offset: 0x001C0206
		static vtkMRCReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMRCReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMRCReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013E75 RID: 81525 RVA: 0x001C202E File Offset: 0x001C022E
		public vtkMRCReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013E76 RID: 81526
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMRCReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E77 RID: 81527 RVA: 0x001C203C File Offset: 0x001C023C
		public new static vtkMRCReader New()
		{
			vtkMRCReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMRCReader.vtkMRCReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMRCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E78 RID: 81528 RVA: 0x001C2090 File Offset: 0x001C0290
		public vtkMRCReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMRCReader.vtkMRCReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013E79 RID: 81529 RVA: 0x001C20D4 File Offset: 0x001C02D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013E7A RID: 81530
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMRCReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E7B RID: 81531 RVA: 0x001C20E0 File Offset: 0x001C02E0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMRCReader.vtkMRCReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E7C RID: 81532
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMRCReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E7D RID: 81533 RVA: 0x001C211C File Offset: 0x001C031C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMRCReader.vtkMRCReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013E7E RID: 81534
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMRCReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E7F RID: 81535 RVA: 0x001C213C File Offset: 0x001C033C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMRCReader.vtkMRCReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013E80 RID: 81536
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMRCReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E81 RID: 81537 RVA: 0x001C2158 File Offset: 0x001C0358
		public override int IsA(string type)
		{
			return vtkMRCReader.vtkMRCReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013E82 RID: 81538
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMRCReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E83 RID: 81539 RVA: 0x001C2178 File Offset: 0x001C0378
		public new static int IsTypeOf(string type)
		{
			return vtkMRCReader.vtkMRCReader_IsTypeOf_05(type);
		}

		// Token: 0x06013E84 RID: 81540
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMRCReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E85 RID: 81541 RVA: 0x001C2194 File Offset: 0x001C0394
		public new vtkMRCReader NewInstance()
		{
			vtkMRCReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMRCReader.vtkMRCReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMRCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013E86 RID: 81542
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMRCReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E87 RID: 81543 RVA: 0x001C21F0 File Offset: 0x001C03F0
		public new static vtkMRCReader SafeDownCast(vtkObjectBase o)
		{
			vtkMRCReader vtkMRCReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMRCReader.vtkMRCReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMRCReader = (vtkMRCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMRCReader.Register(null);
				}
			}
			return vtkMRCReader;
		}

		// Token: 0x06013E88 RID: 81544
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMRCReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E89 RID: 81545 RVA: 0x001C226F File Offset: 0x001C046F
		public virtual void SetFileName(string _arg)
		{
			vtkMRCReader.vtkMRCReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D2 RID: 5842
		public new const string MRFullTypeName = "Kitware.VTK.vtkMRCReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D3 RID: 5843
		public new static readonly string MRClassNameKey = "class vtkMRCReader";
	}
}
