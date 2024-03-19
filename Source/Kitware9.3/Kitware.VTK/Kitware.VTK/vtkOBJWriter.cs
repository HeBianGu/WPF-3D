using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBJWriter
	/// </summary>
	/// <remarks>
	///    write wavefront obj file
	///
	/// vtkOBJWriter writes wavefront obj (.obj) files in ASCII form.
	/// OBJ files contain the geometry including lines, triangles and polygons.
	/// Normals and texture coordinates on points are also written if they exist.
	/// One can specify a texture passing a vtkImageData on port 1.
	/// If a texture is set, additional .mtl and .png files are generated. Those files have the same
	/// name without obj extension.
	/// Alternatively, one can specify a TextureFileName pointing to an existing texture.
	/// In this case a .mtl file is generated pointing to the specified file.
	///
	/// </remarks>
	// Token: 0x0200020C RID: 524
	public class vtkOBJWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600642A RID: 25642 RVA: 0x000902AB File Offset: 0x0008E4AB
		static vtkOBJWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBJWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBJWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600642B RID: 25643 RVA: 0x000902D3 File Offset: 0x0008E4D3
		public vtkOBJWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600642C RID: 25644
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600642D RID: 25645 RVA: 0x000902E4 File Offset: 0x0008E4E4
		public new static vtkOBJWriter New()
		{
			vtkOBJWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600642E RID: 25646 RVA: 0x00090338 File Offset: 0x0008E538
		public vtkOBJWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBJWriter.vtkOBJWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600642F RID: 25647 RVA: 0x0009037C File Offset: 0x0008E57C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006430 RID: 25648
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the file name of the OBJ file.
		/// </summary>
		// Token: 0x06006431 RID: 25649 RVA: 0x00090388 File Offset: 0x0008E588
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJWriter.vtkOBJWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006432 RID: 25650
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the inputs to this writer.
		/// </summary>
		// Token: 0x06006433 RID: 25651 RVA: 0x000903C4 File Offset: 0x0008E5C4
		public new vtkDataSet GetInput(int port)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06006434 RID: 25652
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_GetInputGeometry_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the inputs to this writer.
		/// </summary>
		// Token: 0x06006435 RID: 25653 RVA: 0x00090434 File Offset: 0x0008E634
		public vtkPolyData GetInputGeometry()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_GetInputGeometry_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006436 RID: 25654
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_GetInputTexture_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the inputs to this writer.
		/// </summary>
		// Token: 0x06006437 RID: 25655 RVA: 0x000904A4 File Offset: 0x0008E6A4
		public vtkImageData GetInputTexture()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_GetInputTexture_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06006438 RID: 25656
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006439 RID: 25657 RVA: 0x00090514 File Offset: 0x0008E714
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBJWriter.vtkOBJWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600643A RID: 25658
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBJWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600643B RID: 25659 RVA: 0x00090534 File Offset: 0x0008E734
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBJWriter.vtkOBJWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600643C RID: 25660
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_GetTextureFileName_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the path to an existing texture file for the OBJ.
		/// If this is set, the writer will generate mtllib, usemtl lines
		/// and a .mtl file that points to the existing texture file.
		/// </summary>
		// Token: 0x0600643D RID: 25661 RVA: 0x00090550 File Offset: 0x0008E750
		public virtual string GetTextureFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOBJWriter.vtkOBJWriter_GetTextureFileName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600643E RID: 25662
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJWriter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600643F RID: 25663 RVA: 0x0009058C File Offset: 0x0008E78C
		public override int IsA(string type)
		{
			return vtkOBJWriter.vtkOBJWriter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06006440 RID: 25664
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBJWriter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006441 RID: 25665 RVA: 0x000905AC File Offset: 0x0008E7AC
		public new static int IsTypeOf(string type)
		{
			return vtkOBJWriter.vtkOBJWriter_IsTypeOf_09(type);
		}

		// Token: 0x06006442 RID: 25666
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006443 RID: 25667 RVA: 0x000905C8 File Offset: 0x0008E7C8
		public new vtkOBJWriter NewInstance()
		{
			vtkOBJWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBJWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006444 RID: 25668
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBJWriter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006445 RID: 25669 RVA: 0x00090624 File Offset: 0x0008E824
		public new static vtkOBJWriter SafeDownCast(vtkObjectBase o)
		{
			vtkOBJWriter vtkOBJWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBJWriter.vtkOBJWriter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBJWriter = (vtkOBJWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBJWriter.Register(null);
				}
			}
			return vtkOBJWriter;
		}

		// Token: 0x06006446 RID: 25670
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJWriter_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the file name of the OBJ file.
		/// </summary>
		// Token: 0x06006447 RID: 25671 RVA: 0x000906A3 File Offset: 0x0008E8A3
		public virtual void SetFileName(string _arg)
		{
			vtkOBJWriter.vtkOBJWriter_SetFileName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06006448 RID: 25672
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBJWriter_SetTextureFileName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the path to an existing texture file for the OBJ.
		/// If this is set, the writer will generate mtllib, usemtl lines
		/// and a .mtl file that points to the existing texture file.
		/// </summary>
		// Token: 0x06006449 RID: 25673 RVA: 0x000906B3 File Offset: 0x0008E8B3
		public virtual void SetTextureFileName(string _arg)
		{
			vtkOBJWriter.vtkOBJWriter_SetTextureFileName_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008EF RID: 2287
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBJWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008F0 RID: 2288
		public new static readonly string MRClassNameKey = "class vtkOBJWriter";
	}
}
