using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPLYReader
	/// </summary>
	/// <remarks>
	///    read Stanford University PLY polygonal file format
	///
	/// vtkPLYReader is a source object that reads polygonal data in
	/// Stanford University PLY file format (see
	/// http://graphics.stanford.edu/data/3Dscanrep). It requires that
	/// the elements "vertex" and "face" are defined. The "vertex" element
	/// must have the properties "x", "y", and "z". The "face" element must
	/// have the property "vertex_indices" defined. Optionally, if the "face"
	/// element has the properties "intensity" and/or the triplet "red",
	/// "green", "blue", and optionally "alpha"; these are read and added as scalars
	/// to the output data.
	/// If the "face" element has the property "texcoord" a new TCoords
	/// point array is created and points are duplicated if they have 2 or
	/// more different texture coordinates. Points are duplicated only if
	/// DuplicatePointsForFaceTexture is true (default).
	/// This creates a polygonal data that can be textured without
	/// artifacts. If unique points are required use a vtkCleanPolyData
	/// filter after this reader or use this reader with DuplicatePointsForFaceTexture
	/// set to false.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPLYWriter, vtkCleanPolyData
	/// </seealso>
	// Token: 0x02000166 RID: 358
	public class vtkPLYReader : vtkAbstractPolyDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004415 RID: 17429 RVA: 0x000637F3 File Offset: 0x000619F3
		static vtkPLYReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLYReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004416 RID: 17430 RVA: 0x0006381B File Offset: 0x00061A1B
		public vtkPLYReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004417 RID: 17431
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with merging set to true.
		/// </summary>
		// Token: 0x06004418 RID: 17432 RVA: 0x0006382C File Offset: 0x00061A2C
		public new static vtkPLYReader New()
		{
			vtkPLYReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with merging set to true.
		/// </summary>
		// Token: 0x06004419 RID: 17433 RVA: 0x00063880 File Offset: 0x00061A80
		public vtkPLYReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPLYReader.vtkPLYReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600441A RID: 17434 RVA: 0x000638C4 File Offset: 0x00061AC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600441B RID: 17435
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// A simple, non-exhaustive check to see if a file is a valid ply file.
		/// </summary>
		// Token: 0x0600441C RID: 17436 RVA: 0x000638D0 File Offset: 0x00061AD0
		public static int CanReadFile(string filename)
		{
			return vtkPLYReader.vtkPLYReader_CanReadFile_01(filename);
		}

		// Token: 0x0600441D RID: 17437
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYReader_GetComments_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A simple, non-exhaustive check to see if a file is a valid ply file.
		/// </summary>
		// Token: 0x0600441E RID: 17438 RVA: 0x000638EC File Offset: 0x00061AEC
		public virtual vtkStringArray GetComments()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_GetComments_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0600441F RID: 17439
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYReader_GetDuplicatePointsForFaceTexture_03(HandleRef pThis);

		/// <summary>
		/// If true (default) and the "face" element has the property "texcoord" duplicate
		/// face points if they have 2 or more different texture coordinates.
		/// Otherwise, each texture coordinate for a face point overwrites previously set
		/// texture coordinates for that point.
		/// </summary>
		// Token: 0x06004420 RID: 17440 RVA: 0x0006395C File Offset: 0x00061B5C
		public virtual bool GetDuplicatePointsForFaceTexture()
		{
			return vtkPLYReader.vtkPLYReader_GetDuplicatePointsForFaceTexture_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06004421 RID: 17441
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPLYReader_GetFaceTextureTolerance_04(HandleRef pThis);

		/// <summary>
		/// Tolerance used to detect different texture coordinates for shared
		/// points for faces.
		/// </summary>
		// Token: 0x06004422 RID: 17442 RVA: 0x00063984 File Offset: 0x00061B84
		public virtual float GetFaceTextureTolerance()
		{
			return vtkPLYReader.vtkPLYReader_GetFaceTextureTolerance_04(base.GetCppThis());
		}

		// Token: 0x06004423 RID: 17443
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLYReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004424 RID: 17444 RVA: 0x000639A4 File Offset: 0x00061BA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPLYReader.vtkPLYReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06004425 RID: 17445
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLYReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004426 RID: 17446 RVA: 0x000639C4 File Offset: 0x00061BC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPLYReader.vtkPLYReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06004427 RID: 17447
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYReader_GetReadFromInputStream_07(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputStream
		/// `ReadFromInputStream` has an higher priority than `ReadFromInputString`.
		/// </summary>
		// Token: 0x06004428 RID: 17448 RVA: 0x000639E0 File Offset: 0x00061BE0
		public virtual bool GetReadFromInputStream()
		{
			return vtkPLYReader.vtkPLYReader_GetReadFromInputStream_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06004429 RID: 17449
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPLYReader_GetReadFromInputString_08(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// Note that reading from an input stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to save the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x0600442A RID: 17450 RVA: 0x00063A08 File Offset: 0x00061C08
		public virtual bool GetReadFromInputString()
		{
			return vtkPLYReader.vtkPLYReader_GetReadFromInputString_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600442B RID: 17451
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYReader_GetStream_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify stream to read from
		/// </summary>
		// Token: 0x0600442C RID: 17452 RVA: 0x00063A30 File Offset: 0x00061C30
		public virtual vtkResourceStream GetStream()
		{
			vtkResourceStream vtkResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_GetStream_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceStream = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceStream.Register(null);
				}
			}
			return vtkResourceStream;
		}

		// Token: 0x0600442D RID: 17453
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600442E RID: 17454 RVA: 0x00063AA0 File Offset: 0x00061CA0
		public override int IsA(string type)
		{
			return vtkPLYReader.vtkPLYReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600442F RID: 17455
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLYReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004430 RID: 17456 RVA: 0x00063AC0 File Offset: 0x00061CC0
		public new static int IsTypeOf(string type)
		{
			return vtkPLYReader.vtkPLYReader_IsTypeOf_11(type);
		}

		// Token: 0x06004431 RID: 17457
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004432 RID: 17458 RVA: 0x00063ADC File Offset: 0x00061CDC
		public new vtkPLYReader NewInstance()
		{
			vtkPLYReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004433 RID: 17459
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_ReadFromInputStreamOff_14(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputStream
		/// `ReadFromInputStream` has an higher priority than `ReadFromInputString`.
		/// </summary>
		// Token: 0x06004434 RID: 17460 RVA: 0x00063B36 File Offset: 0x00061D36
		public virtual void ReadFromInputStreamOff()
		{
			vtkPLYReader.vtkPLYReader_ReadFromInputStreamOff_14(base.GetCppThis());
		}

		// Token: 0x06004435 RID: 17461
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_ReadFromInputStreamOn_15(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputStream
		/// `ReadFromInputStream` has an higher priority than `ReadFromInputString`.
		/// </summary>
		// Token: 0x06004436 RID: 17462 RVA: 0x00063B45 File Offset: 0x00061D45
		public virtual void ReadFromInputStreamOn()
		{
			vtkPLYReader.vtkPLYReader_ReadFromInputStreamOn_15(base.GetCppThis());
		}

		// Token: 0x06004437 RID: 17463
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_ReadFromInputStringOff_16(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// Note that reading from an input stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to save the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x06004438 RID: 17464 RVA: 0x00063B54 File Offset: 0x00061D54
		public virtual void ReadFromInputStringOff()
		{
			vtkPLYReader.vtkPLYReader_ReadFromInputStringOff_16(base.GetCppThis());
		}

		// Token: 0x06004439 RID: 17465
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_ReadFromInputStringOn_17(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// Note that reading from an input stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to save the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x0600443A RID: 17466 RVA: 0x00063B63 File Offset: 0x00061D63
		public virtual void ReadFromInputStringOn()
		{
			vtkPLYReader.vtkPLYReader_ReadFromInputStringOn_17(base.GetCppThis());
		}

		// Token: 0x0600443B RID: 17467
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLYReader_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600443C RID: 17468 RVA: 0x00063B74 File Offset: 0x00061D74
		public new static vtkPLYReader SafeDownCast(vtkObjectBase o)
		{
			vtkPLYReader vtkPLYReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLYReader.vtkPLYReader_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLYReader = (vtkPLYReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLYReader.Register(null);
				}
			}
			return vtkPLYReader;
		}

		// Token: 0x0600443D RID: 17469
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetDuplicatePointsForFaceTexture_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true (default) and the "face" element has the property "texcoord" duplicate
		/// face points if they have 2 or more different texture coordinates.
		/// Otherwise, each texture coordinate for a face point overwrites previously set
		/// texture coordinates for that point.
		/// </summary>
		// Token: 0x0600443E RID: 17470 RVA: 0x00063BF3 File Offset: 0x00061DF3
		public virtual void SetDuplicatePointsForFaceTexture(bool _arg)
		{
			vtkPLYReader.vtkPLYReader_SetDuplicatePointsForFaceTexture_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600443F RID: 17471
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetFaceTextureTolerance_20(HandleRef pThis, float _arg);

		/// <summary>
		/// Tolerance used to detect different texture coordinates for shared
		/// points for faces.
		/// </summary>
		// Token: 0x06004440 RID: 17472 RVA: 0x00063C0B File Offset: 0x00061E0B
		public virtual void SetFaceTextureTolerance(float _arg)
		{
			vtkPLYReader.vtkPLYReader_SetFaceTextureTolerance_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004441 RID: 17473
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetInputString_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string s);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// Note that reading from an input stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to save the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x06004442 RID: 17474 RVA: 0x00063C1B File Offset: 0x00061E1B
		public void SetInputString(string s)
		{
			vtkPLYReader.vtkPLYReader_SetInputString_21(base.GetCppThis(), s);
		}

		// Token: 0x06004443 RID: 17475
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetReadFromInputStream_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable reading from an InputStream
		/// `ReadFromInputStream` has an higher priority than `ReadFromInputString`.
		/// </summary>
		// Token: 0x06004444 RID: 17476 RVA: 0x00063C2B File Offset: 0x00061E2B
		public virtual void SetReadFromInputStream(bool _arg)
		{
			vtkPLYReader.vtkPLYReader_SetReadFromInputStream_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004445 RID: 17477
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetReadFromInputString_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable reading from an InputString instead of the default, a file.
		/// Note that reading from an input stream would be more flexible (enabling
		/// other kind of streams) and possibly more efficient because we don't need
		/// to save the whole stream to a string. However a stream interface
		/// does not translate well to python and the string interface satisfies
		/// our current needs. So we leave the stream interface for future work.
		/// </summary>
		// Token: 0x06004446 RID: 17478 RVA: 0x00063C43 File Offset: 0x00061E43
		public virtual void SetReadFromInputString(bool _arg)
		{
			vtkPLYReader.vtkPLYReader_SetReadFromInputString_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004447 RID: 17479
		[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLYReader_SetStream_24(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Specify stream to read from
		/// </summary>
		// Token: 0x06004448 RID: 17480 RVA: 0x00063C5C File Offset: 0x00061E5C
		public virtual void SetStream(vtkResourceStream _arg)
		{
			vtkPLYReader.vtkPLYReader_SetStream_24(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000713 RID: 1811
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLYReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000714 RID: 1812
		public new static readonly string MRClassNameKey = "class vtkPLYReader";
	}
}
