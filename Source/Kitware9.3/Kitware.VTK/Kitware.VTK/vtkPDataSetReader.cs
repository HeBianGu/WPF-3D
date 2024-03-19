using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPDataSetReader
	/// </summary>
	/// <remarks>
	///    Manages reading pieces of a data set.
	///
	/// vtkPDataSetReader will read a piece of a file, it takes as input
	/// a metadata file that lists all of the files in a data set.
	/// </remarks>
	// Token: 0x0200015A RID: 346
	public class vtkPDataSetReader : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004216 RID: 16918 RVA: 0x00060D4B File Offset: 0x0005EF4B
		static vtkPDataSetReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDataSetReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDataSetReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004217 RID: 16919 RVA: 0x00060D73 File Offset: 0x0005EF73
		public vtkPDataSetReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004218 RID: 16920
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004219 RID: 16921 RVA: 0x00060D84 File Offset: 0x0005EF84
		public new static vtkPDataSetReader New()
		{
			vtkPDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600421A RID: 16922 RVA: 0x00060DD8 File Offset: 0x0005EFD8
		public vtkPDataSetReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPDataSetReader.vtkPDataSetReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600421B RID: 16923 RVA: 0x00060E1C File Offset: 0x0005F01C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600421C RID: 16924
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Called to determine if the file can be read by the reader.
		/// </summary>
		// Token: 0x0600421D RID: 16925 RVA: 0x00060E28 File Offset: 0x0005F028
		public int CanReadFile(string filename)
		{
			return vtkPDataSetReader.vtkPDataSetReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x0600421E RID: 16926
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetReader_GetDataType_02(HandleRef pThis);

		/// <summary>
		/// This is set when UpdateInformation is called.
		/// It shows the type of the output.
		/// </summary>
		// Token: 0x0600421F RID: 16927 RVA: 0x00060E48 File Offset: 0x0005F048
		public virtual int GetDataType()
		{
			return vtkPDataSetReader.vtkPDataSetReader_GetDataType_02(base.GetCppThis());
		}

		// Token: 0x06004220 RID: 16928
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// This file to open and read.
		/// </summary>
		// Token: 0x06004221 RID: 16929 RVA: 0x00060E68 File Offset: 0x0005F068
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPDataSetReader.vtkPDataSetReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004222 RID: 16930
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDataSetReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004223 RID: 16931 RVA: 0x00060EA4 File Offset: 0x0005F0A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06004224 RID: 16932
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDataSetReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004225 RID: 16933 RVA: 0x00060EC4 File Offset: 0x0005F0C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06004226 RID: 16934
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004227 RID: 16935 RVA: 0x00060EE0 File Offset: 0x0005F0E0
		public override int IsA(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06004228 RID: 16936
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDataSetReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004229 RID: 16937 RVA: 0x00060F00 File Offset: 0x0005F100
		public new static int IsTypeOf(string type)
		{
			return vtkPDataSetReader.vtkPDataSetReader_IsTypeOf_07(type);
		}

		// Token: 0x0600422A RID: 16938
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600422B RID: 16939 RVA: 0x00060F1C File Offset: 0x0005F11C
		public new vtkPDataSetReader NewInstance()
		{
			vtkPDataSetReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600422C RID: 16940
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDataSetReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600422D RID: 16941 RVA: 0x00060F78 File Offset: 0x0005F178
		public new static vtkPDataSetReader SafeDownCast(vtkObjectBase o)
		{
			vtkPDataSetReader vtkPDataSetReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDataSetReader.vtkPDataSetReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDataSetReader = (vtkPDataSetReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDataSetReader.Register(null);
				}
			}
			return vtkPDataSetReader;
		}

		// Token: 0x0600422E RID: 16942
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDataSetReader_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// This file to open and read.
		/// </summary>
		// Token: 0x0600422F RID: 16943 RVA: 0x00060FF7 File Offset: 0x0005F1F7
		public virtual void SetFileName(string _arg)
		{
			vtkPDataSetReader.vtkPDataSetReader_SetFileName_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F9 RID: 1785
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDataSetReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006FA RID: 1786
		public new static readonly string MRClassNameKey = "class vtkPDataSetReader";
	}
}
