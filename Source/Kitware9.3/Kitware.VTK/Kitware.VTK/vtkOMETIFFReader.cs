using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkOMETIFFReader
	/// </summary>
	/// <remarks>
	///  reader for OME TIFF files
	///
	/// vtkOMETIFFReader supports reading OME-TIFF files. These are TIFF files with
	/// OME meta-data that helps interpret the contents of the TIFF.
	///
	/// The OME-TIFF specification is available here:
	/// https://docs.openmicroscopy.org/ome-model/5.6.3/ome-tiff/specification.html#ome-tiff-specification
	///
	/// The current implementation only supports single-file, multi-page TIFF. It
	/// will not read multi-file OME-TIFF files correctly.
	///
	/// Unlike most image readers, this reader does not support arbitrary sub-extent
	/// requests. This is because the splicing of the `z`, `t`, and `c` planes can make it
	/// tricky to read sub-extents in `z` for certain dimension orders. This reader
	/// supports piece-request instead and satisfies such request by splitting the
	/// `XY` plane into requested number of pieces.
	///
	/// The reader lets the superclass read the whole TIFF volume and then splice it
	/// up into channels, timesteps, and z-planes. The parts are then cached
	/// internally so that subsequent timestep requests can be served without
	/// re-reading the file.
	/// </remarks>
	// Token: 0x0200079B RID: 1947
	public class vtkOMETIFFReader : vtkTIFFReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013FF6 RID: 81910 RVA: 0x001C3E7D File Offset: 0x001C207D
		static vtkOMETIFFReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOMETIFFReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOMETIFFReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013FF7 RID: 81911 RVA: 0x001C3EA5 File Offset: 0x001C20A5
		public vtkOMETIFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013FF8 RID: 81912
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOMETIFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FF9 RID: 81913 RVA: 0x001C3EB4 File Offset: 0x001C20B4
		public new static vtkOMETIFFReader New()
		{
			vtkOMETIFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOMETIFFReader.vtkOMETIFFReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FFA RID: 81914 RVA: 0x001C3F08 File Offset: 0x001C2108
		public vtkOMETIFFReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOMETIFFReader.vtkOMETIFFReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013FFB RID: 81915 RVA: 0x001C3F4C File Offset: 0x001C214C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013FFC RID: 81916
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOMETIFFReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FFD RID: 81917 RVA: 0x001C3F58 File Offset: 0x001C2158
		public override int CanReadFile(string fname)
		{
			return vtkOMETIFFReader.vtkOMETIFFReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06013FFE RID: 81918
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOMETIFFReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FFF RID: 81919 RVA: 0x001C3F78 File Offset: 0x001C2178
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOMETIFFReader.vtkOMETIFFReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014000 RID: 81920
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOMETIFFReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014001 RID: 81921 RVA: 0x001C3FB4 File Offset: 0x001C21B4
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkOMETIFFReader.vtkOMETIFFReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014002 RID: 81922
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOMETIFFReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014003 RID: 81923 RVA: 0x001C3FF0 File Offset: 0x001C21F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOMETIFFReader.vtkOMETIFFReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014004 RID: 81924
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOMETIFFReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014005 RID: 81925 RVA: 0x001C4010 File Offset: 0x001C2210
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOMETIFFReader.vtkOMETIFFReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014006 RID: 81926
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOMETIFFReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014007 RID: 81927 RVA: 0x001C402C File Offset: 0x001C222C
		public override int IsA(string type)
		{
			return vtkOMETIFFReader.vtkOMETIFFReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014008 RID: 81928
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOMETIFFReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014009 RID: 81929 RVA: 0x001C404C File Offset: 0x001C224C
		public new static int IsTypeOf(string type)
		{
			return vtkOMETIFFReader.vtkOMETIFFReader_IsTypeOf_07(type);
		}

		// Token: 0x0601400A RID: 81930
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOMETIFFReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601400B RID: 81931 RVA: 0x001C4068 File Offset: 0x001C2268
		public new vtkOMETIFFReader NewInstance()
		{
			vtkOMETIFFReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOMETIFFReader.vtkOMETIFFReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601400C RID: 81932
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOMETIFFReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601400D RID: 81933 RVA: 0x001C40C4 File Offset: 0x001C22C4
		public new static vtkOMETIFFReader SafeDownCast(vtkObjectBase o)
		{
			vtkOMETIFFReader vtkOMETIFFReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOMETIFFReader.vtkOMETIFFReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOMETIFFReader = (vtkOMETIFFReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOMETIFFReader.Register(null);
				}
			}
			return vtkOMETIFFReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001736 RID: 5942
		public new const string MRFullTypeName = "Kitware.VTK.vtkOMETIFFReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001737 RID: 5943
		public new static readonly string MRClassNameKey = "class vtkOMETIFFReader";
	}
}
