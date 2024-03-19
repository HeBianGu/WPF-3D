using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericMovieWriter
	/// </summary>
	/// <remarks>
	///    an abstract movie writer class.
	///
	/// vtkGenericMovieWriter is the abstract base class for several movie
	/// writers. The input type is a vtkImageData. The Start() method will
	/// open and create the file, the Write() method will output a frame to
	/// the file (i.e. the contents of the vtkImageData), End() will finalize
	/// and close the file.
	/// </remarks>
	/// <seealso>
	///
	/// vtkAVIWriter
	/// </seealso>
	// Token: 0x02000168 RID: 360
	public abstract class vtkGenericMovieWriter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060044CF RID: 17615 RVA: 0x00064571 File Offset: 0x00062771
		static vtkGenericMovieWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericMovieWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericMovieWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060044D0 RID: 17616 RVA: 0x00064599 File Offset: 0x00062799
		public vtkGenericMovieWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060044D1 RID: 17617 RVA: 0x000645A7 File Offset: 0x000627A7
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060044D2 RID: 17618
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericMovieWriter_End_01(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x060044D3 RID: 17619 RVA: 0x000645B2 File Offset: 0x000627B2
		public virtual void End()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_End_01(base.GetCppThis());
		}

		// Token: 0x060044D4 RID: 17620
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericMovieWriter_GetError_02(HandleRef pThis);

		/// <summary>
		/// Was there an error on the last write performed?
		/// </summary>
		// Token: 0x060044D5 RID: 17621 RVA: 0x000645C4 File Offset: 0x000627C4
		public virtual int GetError()
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_GetError_02(base.GetCppThis());
		}

		// Token: 0x060044D6 RID: 17622
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericMovieWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify file name of avi file.
		/// </summary>
		// Token: 0x060044D7 RID: 17623 RVA: 0x000645E4 File Offset: 0x000627E4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericMovieWriter.vtkGenericMovieWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060044D8 RID: 17624
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericMovieWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044D9 RID: 17625 RVA: 0x00064620 File Offset: 0x00062820
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060044DA RID: 17626
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericMovieWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044DB RID: 17627 RVA: 0x00064640 File Offset: 0x00062840
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060044DC RID: 17628
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericMovieWriter_GetStringFromErrorCode_06(uint error);

		/// <summary>
		/// Converts vtkErrorCodes and vtkGenericMovieWriter errors to strings.
		/// </summary>
		// Token: 0x060044DD RID: 17629 RVA: 0x0006465C File Offset: 0x0006285C
		public static string GetStringFromErrorCode(uint error)
		{
			string s = Marshal.PtrToStringAnsi(vtkGenericMovieWriter.vtkGenericMovieWriter_GetStringFromErrorCode_06(error));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060044DE RID: 17630
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericMovieWriter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044DF RID: 17631 RVA: 0x00064694 File Offset: 0x00062894
		public override int IsA(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060044E0 RID: 17632
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericMovieWriter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044E1 RID: 17633 RVA: 0x000646B4 File Offset: 0x000628B4
		public new static int IsTypeOf(string type)
		{
			return vtkGenericMovieWriter.vtkGenericMovieWriter_IsTypeOf_08(type);
		}

		// Token: 0x060044E2 RID: 17634
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericMovieWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044E3 RID: 17635 RVA: 0x000646D0 File Offset: 0x000628D0
		public new vtkGenericMovieWriter NewInstance()
		{
			vtkGenericMovieWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericMovieWriter.vtkGenericMovieWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060044E4 RID: 17636
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericMovieWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044E5 RID: 17637 RVA: 0x0006472C File Offset: 0x0006292C
		public new static vtkGenericMovieWriter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericMovieWriter vtkGenericMovieWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericMovieWriter.vtkGenericMovieWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericMovieWriter = (vtkGenericMovieWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericMovieWriter.Register(null);
				}
			}
			return vtkGenericMovieWriter;
		}

		// Token: 0x060044E6 RID: 17638
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericMovieWriter_SetFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of avi file.
		/// </summary>
		// Token: 0x060044E7 RID: 17639 RVA: 0x000647AB File Offset: 0x000629AB
		public virtual void SetFileName(string _arg)
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_SetFileName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060044E8 RID: 17640
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericMovieWriter_Start_12(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x060044E9 RID: 17641 RVA: 0x000647BB File Offset: 0x000629BB
		public virtual void Start()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_Start_12(base.GetCppThis());
		}

		// Token: 0x060044EA RID: 17642
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericMovieWriter_Write_13(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x060044EB RID: 17643 RVA: 0x000647CA File Offset: 0x000629CA
		public virtual void Write()
		{
			vtkGenericMovieWriter.vtkGenericMovieWriter_Write_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000717 RID: 1815
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericMovieWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000718 RID: 1816
		public new static readonly string MRClassNameKey = "class vtkGenericMovieWriter";

		/// <summary>
		/// Converts vtkErrorCodes and vtkGenericMovieWriter errors to strings.
		/// </summary>
		// Token: 0x02000169 RID: 361
		public enum MovieWriterErrorIds
		{
			/// <summary>enum member</summary>
			// Token: 0x0400071A RID: 1818
			CanNotCompress = 40003,
			/// <summary>enum member</summary>
			// Token: 0x0400071B RID: 1819
			CanNotFormat,
			/// <summary>enum member</summary>
			// Token: 0x0400071C RID: 1820
			ChangedResolutionError,
			/// <summary>enum member</summary>
			// Token: 0x0400071D RID: 1821
			InitError = 40001,
			/// <summary>enum member</summary>
			// Token: 0x0400071E RID: 1822
			NoInputError,
			/// <summary>enum member</summary>
			// Token: 0x0400071F RID: 1823
			UserError = 40000
		}
	}
}
