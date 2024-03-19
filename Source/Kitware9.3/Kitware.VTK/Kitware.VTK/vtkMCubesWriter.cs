using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMCubesWriter
	/// </summary>
	/// <remarks>
	///    write binary marching cubes file
	///
	/// vtkMCubesWriter is a polydata writer that writes binary marching cubes
	/// files. (Marching cubes is an isosurfacing technique that generates many
	/// triangles.) The binary format is supported by W. Lorensen's marching cubes
	/// program (and the vtkSliceCubes object). Each triangle is represented by
	/// three records, with each record consisting of six single precision
	/// floating point numbers representing the a triangle vertex coordinate and
	/// vertex normal.
	///
	/// @warning
	/// Binary files are written in sun/hp/sgi (i.e., Big Endian) form.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMarchingCubes vtkSliceCubes vtkMCubesReader
	/// </seealso>
	// Token: 0x02000209 RID: 521
	public class vtkMCubesWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060063BA RID: 25530 RVA: 0x0008F781 File Offset: 0x0008D981
		static vtkMCubesWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMCubesWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMCubesWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060063BB RID: 25531 RVA: 0x0008F7A9 File Offset: 0x0008D9A9
		public vtkMCubesWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060063BC RID: 25532
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063BD RID: 25533 RVA: 0x0008F7B8 File Offset: 0x0008D9B8
		public new static vtkMCubesWriter New()
		{
			vtkMCubesWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063BE RID: 25534 RVA: 0x0008F80C File Offset: 0x0008DA0C
		public vtkMCubesWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMCubesWriter.vtkMCubesWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060063BF RID: 25535 RVA: 0x0008F850 File Offset: 0x0008DA50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060063C0 RID: 25536
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x060063C1 RID: 25537 RVA: 0x0008F85C File Offset: 0x0008DA5C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMCubesWriter.vtkMCubesWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060063C2 RID: 25538
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060063C3 RID: 25539 RVA: 0x0008F898 File Offset: 0x0008DA98
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060063C4 RID: 25540
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x060063C5 RID: 25541 RVA: 0x0008F908 File Offset: 0x0008DB08
		public new vtkPolyData GetInput(int port)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060063C6 RID: 25542
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_GetLimitsFileName_04(HandleRef pThis);

		/// <summary>
		/// Set/get file name of marching cubes limits file.
		/// </summary>
		// Token: 0x060063C7 RID: 25543 RVA: 0x0008F978 File Offset: 0x0008DB78
		public virtual string GetLimitsFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMCubesWriter.vtkMCubesWriter_GetLimitsFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060063C8 RID: 25544
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMCubesWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063C9 RID: 25545 RVA: 0x0008F9B4 File Offset: 0x0008DBB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060063CA RID: 25546
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMCubesWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063CB RID: 25547 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060063CC RID: 25548
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesWriter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063CD RID: 25549 RVA: 0x0008F9F0 File Offset: 0x0008DBF0
		public override int IsA(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060063CE RID: 25550
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesWriter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063CF RID: 25551 RVA: 0x0008FA10 File Offset: 0x0008DC10
		public new static int IsTypeOf(string type)
		{
			return vtkMCubesWriter.vtkMCubesWriter_IsTypeOf_08(type);
		}

		// Token: 0x060063D0 RID: 25552
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063D1 RID: 25553 RVA: 0x0008FA2C File Offset: 0x0008DC2C
		public new vtkMCubesWriter NewInstance()
		{
			vtkMCubesWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060063D2 RID: 25554
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063D3 RID: 25555 RVA: 0x0008FA88 File Offset: 0x0008DC88
		public new static vtkMCubesWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMCubesWriter vtkMCubesWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesWriter.vtkMCubesWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMCubesWriter = (vtkMCubesWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMCubesWriter.Register(null);
				}
			}
			return vtkMCubesWriter;
		}

		// Token: 0x060063D4 RID: 25556
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesWriter_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of vtk polygon data file to write.
		/// </summary>
		// Token: 0x060063D5 RID: 25557 RVA: 0x0008FB07 File Offset: 0x0008DD07
		public virtual void SetFileName(string _arg)
		{
			vtkMCubesWriter.vtkMCubesWriter_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060063D6 RID: 25558
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesWriter_SetLimitsFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get file name of marching cubes limits file.
		/// </summary>
		// Token: 0x060063D7 RID: 25559 RVA: 0x0008FB17 File Offset: 0x0008DD17
		public virtual void SetLimitsFileName(string _arg)
		{
			vtkMCubesWriter.vtkMCubesWriter_SetLimitsFileName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E9 RID: 2281
		public new const string MRFullTypeName = "Kitware.VTK.vtkMCubesWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008EA RID: 2282
		public new static readonly string MRClassNameKey = "class vtkMCubesWriter";
	}
}
