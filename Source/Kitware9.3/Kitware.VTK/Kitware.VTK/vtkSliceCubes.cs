using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSliceCubes
	/// </summary>
	/// <remarks>
	///    generate isosurface(s) from volume four slices at a time
	///
	/// vtkSliceCubes is a special version of the marching cubes filter. Instead
	/// of ingesting an entire volume at once it processes only four slices at
	/// a time. This way, it can generate isosurfaces from huge volumes. Also, the
	/// output of this object is written to a marching cubes triangle file. That
	/// way, output triangles do not need to be held in memory.
	///
	/// To use vtkSliceCubes you must specify an instance of vtkVolumeReader to
	/// read the data. Set this object up with the proper file prefix, image range,
	/// data origin, data dimensions, header size, data mask, and swap bytes flag.
	/// The vtkSliceCubes object will then take over and read slices as necessary.
	/// You also will need to specify the name of an output marching cubes triangle
	/// file.
	///
	/// @warning
	/// This process object is both a source and mapper (i.e., it reads and writes
	/// data to a file). This is different than the other marching cubes objects
	/// (and most process objects in the system). It's specialized to handle very
	/// large data.
	///
	/// @warning
	/// This object only extracts a single isosurface. This compares with the other
	/// contouring objects in vtk that generate multiple surfaces.
	///
	/// @warning
	/// To read the output file use vtkMCubesReader.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMarchingCubes vtkContourFilter vtkMCubesReader vtkDividingCubes vtkVolumeReader
	/// </seealso>
	// Token: 0x020003E9 RID: 1001
	public class vtkSliceCubes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BFF1 RID: 49137 RVA: 0x0010B5A5 File Offset: 0x001097A5
		static vtkSliceCubes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliceCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliceCubes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BFF2 RID: 49138 RVA: 0x0010B5CD File Offset: 0x001097CD
		public vtkSliceCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BFF3 RID: 49139
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BFF4 RID: 49140 RVA: 0x0010B5DC File Offset: 0x001097DC
		public new static vtkSliceCubes New()
		{
			vtkSliceCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BFF5 RID: 49141 RVA: 0x0010B630 File Offset: 0x00109830
		public vtkSliceCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSliceCubes.vtkSliceCubes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BFF6 RID: 49142 RVA: 0x0010B674 File Offset: 0x00109874
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BFF7 RID: 49143
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify file name of marching cubes output file.
		/// </summary>
		// Token: 0x0600BFF8 RID: 49144 RVA: 0x0010B680 File Offset: 0x00109880
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliceCubes.vtkSliceCubes_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BFF9 RID: 49145
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_GetLimitsFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify file name of marching cubes limits file. The limits file
		/// speeds up subsequent reading of output triangle file.
		/// </summary>
		// Token: 0x0600BFFA RID: 49146 RVA: 0x0010B6BC File Offset: 0x001098BC
		public virtual string GetLimitsFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSliceCubes.vtkSliceCubes_GetLimitsFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BFFB RID: 49147
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliceCubes_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BFFC RID: 49148 RVA: 0x0010B6F8 File Offset: 0x001098F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600BFFD RID: 49149
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSliceCubes_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BFFE RID: 49150 RVA: 0x0010B718 File Offset: 0x00109918
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600BFFF RID: 49151
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_GetReader_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get object to read slices.
		/// </summary>
		// Token: 0x0600C000 RID: 49152 RVA: 0x0010B734 File Offset: 0x00109934
		public virtual vtkVolumeReader GetReader()
		{
			vtkVolumeReader vtkVolumeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_GetReader_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeReader = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeReader.Register(null);
				}
			}
			return vtkVolumeReader;
		}

		// Token: 0x0600C001 RID: 49153
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSliceCubes_GetValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get isosurface contour value.
		/// </summary>
		// Token: 0x0600C002 RID: 49154 RVA: 0x0010B7A4 File Offset: 0x001099A4
		public virtual double GetValue()
		{
			return vtkSliceCubes.vtkSliceCubes_GetValue_06(base.GetCppThis());
		}

		// Token: 0x0600C003 RID: 49155
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliceCubes_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C004 RID: 49156 RVA: 0x0010B7C4 File Offset: 0x001099C4
		public override int IsA(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600C005 RID: 49157
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSliceCubes_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C006 RID: 49158 RVA: 0x0010B7E4 File Offset: 0x001099E4
		public new static int IsTypeOf(string type)
		{
			return vtkSliceCubes.vtkSliceCubes_IsTypeOf_08(type);
		}

		// Token: 0x0600C007 RID: 49159
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C008 RID: 49160 RVA: 0x0010B800 File Offset: 0x00109A00
		public new vtkSliceCubes NewInstance()
		{
			vtkSliceCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C009 RID: 49161
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSliceCubes_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C00A RID: 49162 RVA: 0x0010B85C File Offset: 0x00109A5C
		public new static vtkSliceCubes SafeDownCast(vtkObjectBase o)
		{
			vtkSliceCubes vtkSliceCubes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSliceCubes.vtkSliceCubes_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliceCubes = (vtkSliceCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliceCubes.Register(null);
				}
			}
			return vtkSliceCubes;
		}

		// Token: 0x0600C00B RID: 49163
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of marching cubes output file.
		/// </summary>
		// Token: 0x0600C00C RID: 49164 RVA: 0x0010B8DB File Offset: 0x00109ADB
		public virtual void SetFileName(string _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C00D RID: 49165
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_SetLimitsFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of marching cubes limits file. The limits file
		/// speeds up subsequent reading of output triangle file.
		/// </summary>
		// Token: 0x0600C00E RID: 49166 RVA: 0x0010B8EB File Offset: 0x00109AEB
		public virtual void SetLimitsFileName(string _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetLimitsFileName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C00F RID: 49167
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_SetReader_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get object to read slices.
		/// </summary>
		// Token: 0x0600C010 RID: 49168 RVA: 0x0010B8FC File Offset: 0x00109AFC
		public virtual void SetReader(vtkVolumeReader arg0)
		{
			vtkSliceCubes.vtkSliceCubes_SetReader_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C011 RID: 49169
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_SetValue_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get isosurface contour value.
		/// </summary>
		// Token: 0x0600C012 RID: 49170 RVA: 0x0010B92B File Offset: 0x00109B2B
		public virtual void SetValue(double _arg)
		{
			vtkSliceCubes.vtkSliceCubes_SetValue_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C013 RID: 49171
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_Update_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C014 RID: 49172 RVA: 0x0010B93B File Offset: 0x00109B3B
		public void Update()
		{
			vtkSliceCubes.vtkSliceCubes_Update_16(base.GetCppThis());
		}

		// Token: 0x0600C015 RID: 49173
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSliceCubes_Write_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C016 RID: 49174 RVA: 0x0010B94A File Offset: 0x00109B4A
		public void Write()
		{
			vtkSliceCubes.vtkSliceCubes_Write_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E3F RID: 3647
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliceCubes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E40 RID: 3648
		public new static readonly string MRClassNameKey = "class vtkSliceCubes";
	}
}
