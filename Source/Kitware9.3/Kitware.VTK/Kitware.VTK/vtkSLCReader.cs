using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSLCReader
	/// </summary>
	/// <remarks>
	///    read an SLC volume file.
	///
	/// vtkSLCReader reads an SLC file and creates a structured point dataset.
	/// The size of the volume and the data spacing is set from the SLC file
	/// header.
	/// </remarks>
	// Token: 0x020007A2 RID: 1954
	public class vtkSLCReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060140DE RID: 82142 RVA: 0x001C55D3 File Offset: 0x001C37D3
		static vtkSLCReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLCReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLCReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060140DF RID: 82143 RVA: 0x001C55FB File Offset: 0x001C37FB
		public vtkSLCReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060140E0 RID: 82144
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLCReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140E1 RID: 82145 RVA: 0x001C560C File Offset: 0x001C380C
		public new static vtkSLCReader New()
		{
			vtkSLCReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140E2 RID: 82146 RVA: 0x001C5660 File Offset: 0x001C3860
		public vtkSLCReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSLCReader.vtkSLCReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060140E3 RID: 82147 RVA: 0x001C56A4 File Offset: 0x001C38A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060140E4 RID: 82148
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLCReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file an SLC file?
		/// </summary>
		// Token: 0x060140E5 RID: 82149 RVA: 0x001C56B0 File Offset: 0x001C38B0
		public override int CanReadFile(string fname)
		{
			return vtkSLCReader.vtkSLCReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x060140E6 RID: 82150
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLCReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// SLC
		/// </summary>
		// Token: 0x060140E7 RID: 82151 RVA: 0x001C56D0 File Offset: 0x001C38D0
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSLCReader.vtkSLCReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060140E8 RID: 82152
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLCReader_GetError_03(HandleRef pThis);

		/// <summary>
		/// Was there an error on the last read performed?
		/// </summary>
		// Token: 0x060140E9 RID: 82153 RVA: 0x001C570C File Offset: 0x001C390C
		public virtual int GetError()
		{
			return vtkSLCReader.vtkSLCReader_GetError_03(base.GetCppThis());
		}

		// Token: 0x060140EA RID: 82154
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLCReader_GetFileExtensions_04(HandleRef pThis);

		/// <summary>
		/// .slc
		/// </summary>
		// Token: 0x060140EB RID: 82155 RVA: 0x001C572C File Offset: 0x001C392C
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkSLCReader.vtkSLCReader_GetFileExtensions_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060140EC RID: 82156
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLCReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140ED RID: 82157 RVA: 0x001C5768 File Offset: 0x001C3968
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSLCReader.vtkSLCReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060140EE RID: 82158
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLCReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140EF RID: 82159 RVA: 0x001C5788 File Offset: 0x001C3988
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSLCReader.vtkSLCReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060140F0 RID: 82160
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLCReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140F1 RID: 82161 RVA: 0x001C57A4 File Offset: 0x001C39A4
		public override int IsA(string type)
		{
			return vtkSLCReader.vtkSLCReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060140F2 RID: 82162
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLCReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140F3 RID: 82163 RVA: 0x001C57C4 File Offset: 0x001C39C4
		public new static int IsTypeOf(string type)
		{
			return vtkSLCReader.vtkSLCReader_IsTypeOf_08(type);
		}

		// Token: 0x060140F4 RID: 82164
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLCReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140F5 RID: 82165 RVA: 0x001C57E0 File Offset: 0x001C39E0
		public new vtkSLCReader NewInstance()
		{
			vtkSLCReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060140F6 RID: 82166
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLCReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140F7 RID: 82167 RVA: 0x001C583C File Offset: 0x001C3A3C
		public new static vtkSLCReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLCReader vtkSLCReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLCReader.vtkSLCReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLCReader = (vtkSLCReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLCReader.Register(null);
				}
			}
			return vtkSLCReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001744 RID: 5956
		public new const string MRFullTypeName = "Kitware.VTK.vtkSLCReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001745 RID: 5957
		public new static readonly string MRClassNameKey = "class vtkSLCReader";
	}
}
