using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlot3DMetaReader
	/// </summary>
	/// <remarks>
	///    reads meta-files points to PLOT3D files
	///
	/// The main goal of this reader is to make it easy to read PLOT3D files,
	/// specifically time series of PLOT3D files. PLOT3D files can take many
	/// different forms based on their content. Unfortunately, it is not a
	/// self-describing format therefore the user needs to pass information
	/// about the contents of the file to the reader. Normally, this is done
	/// by setting a number of member variables. The goal of this reader is
	/// to provide a simple format that enable the writer of the PLOT3D file
	/// to describe its settings as well as group a number of files as a time
	/// series. Note that for binary files, the auto-detect-format option,
	/// which is on by default negates the need to specify most other option.
	/// However, this reader is still very useful when trying to read file
	/// series even for binary files. The format for this meta-file is very simple
	/// and is based on JSON (there is no need to know anything about JSON to
	/// understand this format). Below is an example with comments (followed by //)
	/// that describe the format. Note that the PLOT3D file names are relative
	/// to the location of the meta-file unless they start with a leading /.
	///
	/// \verbatim
	/// {
	/// "auto-detect-format" : true // Tells the reader to try to figure out the format automatically.
	/// Only works
	///                             // with binary file. This is on by default, negating the need for
	/// most other
	///                             // options for binary files (format, byte-order, precision,
	/// multi-grid,
	///                             // blanking, 2D).
	/// "format" : "binary",  // Is this a binary or ascii file, values : binary, ascii
	/// "byte-order" : "big", // Byte order for binary files, values : little, big (denoting little or
	/// big endian) "precision" : 32,     // Precision of floating point values, can be 32 or 64 (bits)
	/// "multi-grid" : false, // Is this a multi-grid file, values: true, false
	/// "language" : "C",     // Which language was this file written in, values : C, fortran. This is
	///                       // used to determine if an binary PLOT3D file contains byte counts, used by
	///                       // Fortran IO routines.
	/// "blanking" : false,   // Does this file have blanking information (iblanks), values : true, false
	/// "2D" : false,         // Is this a 2D dataset, values : true, false
	/// "R" : 8.314,          // The value of the gas constant, default is 1.0. Set this according to the
	/// dimensions you use "gamma" : 1.4,        // Ratio of specific heats. Default is 1.4. "functions":
	/// [ 110, 200, 201 ],  // Additional derived values to calculate. This is an array of integers
	/// formatted
	///                                  // as [ value, value, value, ...]
	/// "filenames" : [     // List of xyz (geometry) and q (value) file names along with the time
	/// values.
	///                     // This is an array which contains items in the format:
	///                     // {"time" : values, "xyz" : "xyz file name", "q" : "q file name", "function"
	/// : "function file name"}
	///                     // Note that q and function are optional. Also, you can repeat the same file
	/// name for xyz or q
	///                     // if they don't change over time. The reader will not read files
	/// unnecessarily. { "time" : 3.5, "xyz" : "combxyz.bin", "q" : "combq.1.bin", "function" :
	/// "combf.1.bin" }, { "time" : 4.5, "xyz" : "combxyz.bin", "q" : "combq.2.bin", "function" :
	/// "combf.2.bin" }
	/// ],
	/// "function-names" : ["density", "velocity_x", "temperature"]
	///                   // list of names of functions in function files
	/// }
	/// \endverbatim
	///
	/// This reader leverages vtkMultiBlockPLOT3DReader to do the actual
	/// reading so you may want to refer to the documentation of
	/// vtkMultiBlockPLOT3DReader about the details of some of these
	/// parameters including the function numbers for derived value
	/// calculation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiBlockPLOT3DReader
	/// </seealso>
	// Token: 0x02000161 RID: 353
	public class vtkPlot3DMetaReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600431A RID: 17178 RVA: 0x00062574 File Offset: 0x00060774
		static vtkPlot3DMetaReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlot3DMetaReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot3DMetaReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600431B RID: 17179 RVA: 0x0006259C File Offset: 0x0006079C
		public vtkPlot3DMetaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600431C RID: 17180
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3DMetaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600431D RID: 17181 RVA: 0x000625AC File Offset: 0x000607AC
		public new static vtkPlot3DMetaReader New()
		{
			vtkPlot3DMetaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3DMetaReader.vtkPlot3DMetaReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600431E RID: 17182 RVA: 0x00062600 File Offset: 0x00060800
		public vtkPlot3DMetaReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlot3DMetaReader.vtkPlot3DMetaReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600431F RID: 17183 RVA: 0x00062644 File Offset: 0x00060844
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004320 RID: 17184
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3DMetaReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the meta PLOT3D filename. See the class documentation for
		/// format details.
		/// </summary>
		// Token: 0x06004321 RID: 17185 RVA: 0x00062650 File Offset: 0x00060850
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPlot3DMetaReader.vtkPlot3DMetaReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004322 RID: 17186
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot3DMetaReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004323 RID: 17187 RVA: 0x0006268C File Offset: 0x0006088C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlot3DMetaReader.vtkPlot3DMetaReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004324 RID: 17188
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlot3DMetaReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004325 RID: 17189 RVA: 0x000626AC File Offset: 0x000608AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlot3DMetaReader.vtkPlot3DMetaReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06004326 RID: 17190
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot3DMetaReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004327 RID: 17191 RVA: 0x000626C8 File Offset: 0x000608C8
		public override int IsA(string type)
		{
			return vtkPlot3DMetaReader.vtkPlot3DMetaReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06004328 RID: 17192
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlot3DMetaReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004329 RID: 17193 RVA: 0x000626E8 File Offset: 0x000608E8
		public new static int IsTypeOf(string type)
		{
			return vtkPlot3DMetaReader.vtkPlot3DMetaReader_IsTypeOf_05(type);
		}

		// Token: 0x0600432A RID: 17194
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3DMetaReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600432B RID: 17195 RVA: 0x00062704 File Offset: 0x00060904
		public new vtkPlot3DMetaReader NewInstance()
		{
			vtkPlot3DMetaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3DMetaReader.vtkPlot3DMetaReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600432C RID: 17196
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlot3DMetaReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600432D RID: 17197 RVA: 0x00062760 File Offset: 0x00060960
		public new static vtkPlot3DMetaReader SafeDownCast(vtkObjectBase o)
		{
			vtkPlot3DMetaReader vtkPlot3DMetaReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlot3DMetaReader.vtkPlot3DMetaReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot3DMetaReader = (vtkPlot3DMetaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot3DMetaReader.Register(null);
				}
			}
			return vtkPlot3DMetaReader;
		}

		// Token: 0x0600432E RID: 17198
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlot3DMetaReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the meta PLOT3D filename. See the class documentation for
		/// format details.
		/// </summary>
		// Token: 0x0600432F RID: 17199 RVA: 0x000627DF File Offset: 0x000609DF
		public virtual void SetFileName(string _arg)
		{
			vtkPlot3DMetaReader.vtkPlot3DMetaReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000708 RID: 1800
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlot3DMetaReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000709 RID: 1801
		public new static readonly string MRClassNameKey = "class vtkPlot3DMetaReader";
	}
}
